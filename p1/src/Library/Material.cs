namespace Ucu.Poo.Defense
{
    public class Material
    {
        public string Name { get; set; }

        public MaterialType Type { get; set; }

       //se agrega la propiedad IsDangerous booleana para saber si el material es peligroso o no
        public bool IsDangerous{ get; set;}
        
        public Material(string name, MaterialType type)
        {
            this.Name = name;
            this.Type = type;
            this.IsDangerous = type.IsDangerous;
        }
    
    
    
    }
}