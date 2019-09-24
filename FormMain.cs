using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WinHash
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btSelectFile_Click(object sender, EventArgs e)
        {
            // открытие диалога для выбора файла
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // показываем путь к файлу
                    lFile.Text = ofd.FileName;

                    // читаем файл
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                    using (BufferedStream bs = new BufferedStream(fs))
                    {
                        using (SHA1Managed sha1 = new SHA1Managed())
                        {
                            // через sha1 вычисляем хэш файла
                            byte[] hash = sha1.ComputeHash(bs);
                            StringBuilder formatted = new StringBuilder(2 * hash.Length);
                            foreach (byte b in hash)
                            {
                                // перевод байта в 16 формат с 2мя символами
                                formatted.AppendFormat("{0:X2}", b);
                            }
                            // показ хэша
                            tbHash.Text = formatted.ToString();
                        }
                    }
                }
            }
        }
    }
}
