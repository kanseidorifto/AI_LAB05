using AI_LAB05.Classes;

namespace AI_LAB05.UserControl
{
    public static class Prompt
    {
        public static Category? ShowDialog(List<Category> classes)
        {
            Forms.SaveToBatchForm prompt = new();

            foreach (var item in classes)
            {
                prompt.comboBox1.Items.Add(item._category_num.ToString() +": "+ item._category_name);
            }
            prompt.comboBox1.Items.Add("+");
            prompt.comboBox1.SelectedIndex = 0;
            prompt.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            prompt.btn_Ok.DialogResult = DialogResult.OK;
            prompt.btn_Ok.Click += (sender, e) => { prompt.Close(); };
            prompt.AcceptButton = prompt.btn_Ok;

            if(prompt.ShowDialog() == DialogResult.OK) 
            {
                classes.Add(new Category(prompt.comboBox1.SelectedIndex, prompt.textBox1.Text));
                return classes[prompt.comboBox1.SelectedIndex];
            }
            else
            {
                return null;
            }
        }
    }
}
