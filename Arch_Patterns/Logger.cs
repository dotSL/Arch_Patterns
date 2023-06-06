namespace Arch_Patterns
{
    internal class Logger
    {
        private StreamWriter _streamWriter;
        private Unit _unit;

        public Logger(Unit unit, string fileName)
        {
            _streamWriter = new StreamWriter(fileName);
            _unit = unit;
        }

        public void log(int damage)
        {
            _streamWriter.WriteLine("=================================");
            if (_unit.DefencePoints < damage)
                _streamWriter.WriteLine(String.Format("Unit with name {0} has gotten damage {1}", _unit.Name, damage));
            else
                _streamWriter.WriteLine(String.Format("Unit with name {0} didn't recieve damage}", _unit.Name));
            _streamWriter.WriteLine("=================================");
        }
    }
}