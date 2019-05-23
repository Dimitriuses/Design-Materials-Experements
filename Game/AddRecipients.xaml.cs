using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Game
{
    /// <summary>
    /// Interaction logic for AddRecipients.xaml
    /// </summary>
    public partial class AddRecipients : Window
    {
        List<SelectableVievModel> Items = new List<SelectableVievModel>();
        public AddRecipients()
        {
            Items.Add(new SelectableVievModel { Id = 0, Code = "DM", Name = "Dmitrius Shpack", Description = "@dmitr" });
            Items.Add(new SelectableVievModel { Id = 1, Code = "MC", Name = "Meridel Coen", Description = "@mer1de1" });
            Items.Add(new SelectableVievModel { Id = 2, Code = "CD", Name = "Celene Delieu", Description = "@deli6u" });
            Items.Add(new SelectableVievModel { Id = 3, Code = "BA", Name = "Brynna Abdee", Description = "@abd99" });
            Items.Add(new SelectableVievModel { Id = 4, Code = "MA", Name = "Moss Abell", Description = "@mo55" });
            Items.Add(new SelectableVievModel { Id = 5, Code = "TL", Name = "Teresina Leirmonth", Description = "@teres1ermoth" });
            Items.Add(new SelectableVievModel { Id = 6, Code = "MB", Name = "Marti Bottonk", Description = "@mari8ott" });
            Items.Add(new SelectableVievModel { Id = 7, Code = "KC", Name = "Karie Castellucci", Description = "@karcas" });
            Items.Add(new SelectableVievModel { Id = 8, Code = "NA", Name = "Nealy Alexander", Description = "@nealder" });
            Items.Add(new SelectableVievModel { Id = 9, Code = "HA", Name = "Holly Asbury", Description = "@holishit" });
            Items.Add(new SelectableVievModel { Id = 10, Code = "MC", Name = "Matelda Curtois", Description = "@matelcuu" });
            Items.Add(new SelectableVievModel { Id = 11, Code = "EY", Name = "Emelyne Yeomans", Description = "@emailyeo" });
            Items.Add(new SelectableVievModel { Id = 12, Code = "ZB", Name = "Zitella Bedrosian", Description = "@ziteb6ros" });
            Items.Add(new SelectableVievModel { Id = 13, Code = "MB", Name = "Mill Baudassi", Description = "@millbadu" });
            Items.Add(new SelectableVievModel { Id = 14, Code = "G", Name = "Georgie Gribbins	", Description = "@ggeor1" });
            Items.Add(new SelectableVievModel { Id = 15, Code = "NT", Name = "Nataline Triggle", Description = "@natalitt" });
            InitializeComponent();
            //pararara.Items.Add(new SelectableVievModel { Code = "DM", Name = "Dmitrius Shpack", Description = "@dmitr" });
        }

        private void FindUsersByParticipans_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<SelectableVievModel> TMP = new List<SelectableVievModel>();
            if (pararara.Items.Count > 0)
            {
                foreach (SelectableVievModel item in pararara.Items)
                {
                    if (item != null && item.IsSelected)
                    {
                        TMP.Add(item);
                    }
                }
            }
            pararara.Items.Clear();
            foreach (SelectableVievModel item in TMP)
            {
                pararara.Items.Add(item);
            }
            List<SelectableVievModel> find = new List<SelectableVievModel>();
            find = finder(FindUsersByParticipans.Text);
            if (find.Count > 0)
            {
                foreach (SelectableVievModel item in find)
                {
                    if (item != null && !FindIdenticalItemForList(TMP, item)) 
                    {
                        pararara.Items.Add(item);
                    }

                }
            }
            
            //pararara.Items.Add();
            
        }

        private bool FindIdenticalItemForList(List<SelectableVievModel> list,SelectableVievModel Finditem)
        {
            foreach (SelectableVievModel item in list)
            {
                if(Finditem == item)
                {
                    return true;
                }
            }
            return false;
        }

        private List<SelectableVievModel> finder(string find)
        {
            List<SelectableVievModel> tmp = new List<SelectableVievModel>();
            if(find != String.Empty)
            {
                foreach (SelectableVievModel item in Items)
                {
                    if (item.Name.Contains(find) || item.Description.Contains(find) || item.Code.Contains(find))
                    {
                        tmp.Add(item);
                    }
                }
            }
            return tmp;
            
        }
    }
}
