using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Azure.Batch.Samples.Common
{
    public class AccountSettings
    {
        public string BatchServiceUrl { get; set; }
        public string BatchAccountName { get; set; }
        public string BatchAccountKey { get; set; }

        public string StorageServiceUrl { get; set; }
        public string StorageAccountName { get; set; }
        public string StorageAccountKey { get; set; }
        public string StorageAccountName1 { get; set; }
        public string StorageAccountKey1 { get; set; }
        public string StorageAccountName2 { get; set; }
        public string StorageAccountKey2 { get; set; }
        public string StorageAccountName3 { get; set; }
        public string StorageAccountKey3 { get; set; }

        public void Randomize()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);
            switch (randomNumber)
            {
                case 1:
                    this.StorageAccountName = this.StorageAccountName1;
                    this.StorageAccountKey = this.StorageAccountKey1;
                    break;
                case 2:
                    this.StorageAccountName = this.StorageAccountName2;
                    this.StorageAccountKey = this.StorageAccountKey2;
                    break;
                case 3:
                    this.StorageAccountName = this.StorageAccountName3;
                    this.StorageAccountKey = this.StorageAccountKey3;
                    break;
            }
            Console.WriteLine("Random generator says {0}", randomNumber.ToString());
            Console.WriteLine("Using storage account {0}", this.StorageAccountName);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            AddSetting(stringBuilder, "BatchAccountName", this.BatchAccountName);
            AddSetting(stringBuilder, "BatchAccountKey", this.BatchAccountKey);
            AddSetting(stringBuilder, "BatchServiceUrl", this.BatchServiceUrl);

            AddSetting(stringBuilder, "StorageAccountName", this.StorageAccountName1);
            AddSetting(stringBuilder, "StorageAccountKey", this.StorageAccountKey1);
            AddSetting(stringBuilder, "StorageServiceUrl", this.StorageServiceUrl);

            return stringBuilder.ToString();
        }

        private static void AddSetting(StringBuilder stringBuilder, string settingName, object settingValue)
        {
            stringBuilder.AppendFormat("{0} = {1}", settingName, settingValue).AppendLine();
        }
}
}
