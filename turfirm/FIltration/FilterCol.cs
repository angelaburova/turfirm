using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turfirm
{
    class FilterCol
    {
        private Filtres form;
       static public List<Filter> filtres;
        public FilterCol(Filtres obj)
        {
            filtres = new List<Filter>();
            form = obj;
        }

        public void checkingBoxes()
        {
            if (form.checkBox1.Checked == true)
            {
                typeFilter type = new typeFilter();
                string a = form.comboBox1.Text;
                type.setValue(form.comboBox1.Text);
                type.setType("string");
                filtres.Add(type);
            }
            if (form.checkBox2.Checked == true)
            {
                countryFilter country = new countryFilter();
                country.setValue(form.comboBox2.Text);
                country.setType("string");
                filtres.Add(country);
            }
            if (form.checkBox3.Checked == true)
            {
                visaFilter visa = new visaFilter();
                visa.setValue(form.checkBox9.Checked.ToString());
                visa.setType("bool");
                filtres.Add(visa);

            }
            if (form.checkBox4.Checked == true)
            {
                hotelFilter hotel = new hotelFilter();
                hotel.setValue(form.comboBox4.Text);
                hotel.setType("string");
                filtres.Add(hotel);
                
            }
            if (form.checkBox5.Checked == true)
            {
                transportFilter transport = new transportFilter();
                transport.setValue(form.comboBox5.Text);
                transport.setType("string");
                filtres.Add(transport);
                
            }
            if (form.checkBox6.Checked == true)
            {
                foodFilter food = new foodFilter();
                food.setValue(form.comboBox6.Text);
                food.setType("string");
                filtres.Add(food);
            }
            if (form.checkBox7.Checked == true)
            {
                priceFromFilter price_from = new priceFromFilter();
                priceToFilter price_to = new priceToFilter();
                price_from.setValue(form.textBox1.Text);
                price_to.setValue(form.textBox2.Text);
                price_from.setType("double");
                price_to.setType("double");
                filtres.Add(price_from);
                filtres.Add(price_to);
            }
            if (form.checkBox8.Checked == true)
            {
                valutaFilter valuta = new valutaFilter();
                valuta.setValue(form.comboBox8.Text);
                valuta.setType("string");
                filtres.Add(valuta);
                
            }
        }
    }
}
