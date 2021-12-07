namespace Captura.Models
{
    class BassItem : NotifyPropertyChanged, IAudioItem
    {
        public int Id { get; }

        public BassItem(int Id, string Name, bool Default)
        {
            this.Id = Id;
            this.Name = Name;
            this.Default = Default;
        }

        public string Name { get; }
        public bool Default { get; }

        bool _active;

        public bool Active
        {
            get => _active;
            set
            {
                _active = value;
                
                OnPropertyChanged();
            }
        }

        public override string ToString() => Name;
    }
}