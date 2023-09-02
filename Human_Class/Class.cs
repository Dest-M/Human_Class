namespace Human_Class
{
    internal class Human
    {
        string name;
        string gender;
        int age = 0;
        public Human parent1 = null;
        public Human parent2 = null;
        public Human partner = null;
        public Human child = null;
        public Human(string name, string gender, int age)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }
        public Human(string name, string gender, int age, Human p1, Human p2)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;

            if (p1 != null && p2 != null)
            {
                if (p1.age > age && p2.age > age)
                {
                    parent1 = p1;
                    parent2 = p2;
                    p1.child = this;
                    p2.child = this;
                    p1.partner = p2;
                    p2.partner = p1;
                }
                else
                {
                    Console.WriteLine("ERROR Age of child can not be higher than parents");
                }
            }
            else
            {
                Console.WriteLine(name + "ERROR Comp");
            }

        }
        public string GetName()
        {
            return name;
        }
        public string getGender()
        {
            return gender;
        }
        public string getAge()
        {
            return Convert.ToString(age);
        }
        public override string ToString()
        {
            string str = "";
            if (parent1 != null)
            {
                str += "Parent 1: " + parent1.name + " ";
            }
            if (parent2 != null)
            {
                str += "Parent 2:" + parent2.name + " ";
            }
            if (child != null)
            {
                str += "Child: " + child.name + " ";
            }
            return name + " " + gender + " " + Convert.ToString(age) + " " + str;
        }
    }
}

