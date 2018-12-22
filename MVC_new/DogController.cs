using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_new
{
    class DogController
    {
        private Dog model;
        private DogView view;

        public DogController(Dog model, DogView view)
        {
            this.model = model;
            this.view = view;
        }

        public void setName(String name)
        {
            model.name = name;
        }
        public void setAge(int age)
        {
            model.age = age;
        }
        public String getName()
        {
            return model.name;
        }
        public int getAge()
        {
            return model.age;
        }
        public void updateView()
        {
            view.printDogInfo(model.name, model.age);
        }
    }
}
