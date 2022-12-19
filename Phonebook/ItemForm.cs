using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Phonebook.Classes;
using System.Xml.Linq;
using System.IO;
using System.Drawing.Imaging;
using Phonebook.Resources;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Phonebook
{
    public partial class ItemForm : Form
    {
        public string ItemID = "";

        bool NewItem = false;
        bool EditItem = false;

        public Dictionary<string, CategoryEnum> Categories { get; private set; }

        public ItemForm(bool newItem, bool editItem)
        {
            InitializeComponent();
            this.tableLayoutPanel1.CellPaint += new TableLayoutCellPaintEventHandler(tableLayoutPanel1_CellPaint);

            //////////////////////
            this.NewItem = newItem;
            this.EditItem = editItem;

            if (NewItem)
                this.Text = "Add New Item";

            else if (EditItem)
                this.Text = "Edit Item";

            InitializeComboBoxCategory();
        }

        private void InitializeComboBoxCategory()
        {
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            Categories = new Dictionary<string, CategoryEnum>();

            MemberInfo[] fis = typeof(CategoryEnum).GetFields();

            for (int i = 1; i < fis.Length; i++)
            {
                DescriptionAttribute[] attributes = (DescriptionAttribute[])fis[i].GetCustomAttributes(typeof(DescriptionAttribute), false);

                var description = attributes[0].Description;

                comboBoxCategory.Items.Add(description);

                Categories.Add(description, (CategoryEnum)i);
            }

            if (NewItem)
                comboBoxCategory.CheckBoxItems.Single(x => x.Text == "عمومی").Checked = true;
        }

        void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            try
            {
                if (e.Row % 2 == 0)
                {
                    Graphics g = e.Graphics;
                    Rectangle r = e.CellBounds;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(225, 225, 225)), r);
                }
            }
            catch (Exception ex)
            {
                StackFrame file_info = new StackFrame(true);
                Messages.error(ref file_info, ex.Message, this);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                #region add new item

                if (NewItem)
                {

                    if (textBoxLastName.Text.Trim() == "")
                    {
                        errorProvider1.SetError(textBoxLastName, "لطفا نام خانوادگی را وارد کنید");
                        return;
                    }

                    if (!string.IsNullOrWhiteSpace(textBoxMobile.Text) &&
                        PhonebookRepository.Instance.IsExist(textBoxMobile.Text.Trim()))
                    {
                        errorProvider1.SetError(textBoxMobile, "این شماره تکراری می باشد.");
                        return;
                    }

                    if (!string.IsNullOrEmpty(textBoxMobile.Text) && !new Regex(@"09\d{9}$").IsMatch(textBoxMobile.Text))
                    {
                        errorProvider1.SetError(textBoxMobile, "فرمت شماره وارد شده صحیح نمی باشد.");
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(comboBoxCategory.Text))
                    {
                        errorProvider1.SetError(comboBoxCategory, "لطفا دسته بندی را وارد کنید");
                        return;
                    }

                    var stringCategory = PhonebookUtility.GetStringCategoryFromCheckBoxComboBox(comboBoxCategory);

                    var phonebookRecord = new PhonebookRecord(
                                   textBoxFirstName.Text.Trim(),
                                   textBoxLastName.Text.Trim(),
                                   textBoxOrganization.Text.Trim(),
                                   textBoxLandlineNumber.Text.Trim(),
                                   textBoxMobile.Text.Trim(),
                                   textBoxFax.Text.Trim(),
                                   textBoxTelegramNumber.Text.Trim(),
                                   stringCategory,
                                   textBoxDescription.Text.Trim());

                    PhonebookRepository.Instance.Add(phonebookRecord);
                    PhonebookRepository.Instance.AddPhoneBookCategories(phonebookRecord.Id, phonebookRecord.CategoryIds);
                }

                #endregion

                #region edit item

                else if (EditItem)
                {
                    if (textBoxLastName.Text.Trim() == "")
                    {
                        errorProvider1.SetError(textBoxLastName, "لطفا نام خانوادگی را وارد کنید");
                        return;
                    }

                    if (!string.IsNullOrWhiteSpace(textBoxMobile.Text) &&
                        IsDuplicated(textBoxMobile.Text.Trim(), Guid.Parse(ItemID)))
                    {
                        errorProvider1.SetError(textBoxMobile, "این شماره تکراری (متعلق به فرد دیگری) می باشد.");
                        return;
                    }

                    var stringCategory = PhonebookUtility.GetStringCategoryFromCheckBoxComboBox(comboBoxCategory);

                    var phonebookRecord = new PhonebookRecord
                    {
                        Id = Guid.Parse(ItemID),
                        FirstName = textBoxFirstName.Text.Trim(),
                        LastName = textBoxLastName.Text.Trim(),
                        Organization = textBoxOrganization.Text.Trim(),
                        LandlineNumber = textBoxLandlineNumber.Text.Trim(),
                        MobileNumber = textBoxMobile.Text.Trim(),
                        FaxNumber = textBoxFax.Text.Trim(),
                        TelegramNumber = textBoxTelegramNumber.Text.Trim(),
                        Description = textBoxDescription.Text.Trim(),
                        CategoryIds = stringCategory
                    };

                    PhonebookRepository.Instance.Update(phonebookRecord);
                    PhonebookRepository.Instance.UpdatePhoneBookCategories(phonebookRecord.Id, phonebookRecord.CategoryIds);
                }

                #endregion

                this.Close();
            }
            catch (Exception ex)
            {
                StackFrame file_info = new StackFrame(true);
                Messages.error(ref file_info, ex.Message, this);
            }
        }

        private bool IsDuplicated(string mobileNumber, Guid guid)
        {
            var phonebookRecord = PhonebookRepository.Instance.GetPhonebookRecordByMobileNumber(mobileNumber);

            if (phonebookRecord == null)
                return false;

            var isDuplicated = phonebookRecord.Id != guid;

            return isDuplicated;
        }

        #region

        Image ResizeImage(Image FullsizeImage, int NewWidth, int MaxHeight, bool OnlyResizeIfWider)
        {
            // Prevent using images internal thumbnail
            FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);

            if (OnlyResizeIfWider)
            {
                if (FullsizeImage.Width <= NewWidth)
                {
                    NewWidth = FullsizeImage.Width;
                }
            }

            int NewHeight = FullsizeImage.Height * NewWidth / FullsizeImage.Width;
            if (NewHeight > MaxHeight)
            {
                // Resize with height instead
                NewWidth = FullsizeImage.Width * MaxHeight / FullsizeImage.Height;
                NewHeight = MaxHeight;
            }

            System.Drawing.Image NewImage = FullsizeImage.GetThumbnailImage(NewWidth, NewHeight, null, IntPtr.Zero);

            // Clear handle to original file so that we can overwrite it if necessary
            FullsizeImage.Dispose();

            // Save resized picture
            return NewImage;
        }

        string ImageToBase64String(Image image, ImageFormat format)
        {
            MemoryStream memory = new MemoryStream();
            image.Save(memory, format);
            string base64 = Convert.ToBase64String(memory.ToArray());
            memory.Close();

            return base64;
        }

        Image ImageFromBase64String(string base64)
        {
            MemoryStream memory = new MemoryStream(Convert.FromBase64String(base64));
            Image result = Image.FromStream(memory);
            memory.Close();

            return result;
        }

        #endregion

    }
}
