using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAdapterApp.Domain
{
    public class Specification
    {
        List<string> _specification;
        public List<string> CreateSpec()
        {
            _specification = new List<string> { "Наименование",
            "Ядро", "Техпроцесс, нм", "Транзисторов, млн", "Частота работы ядра, МГц", "Частота работы шейдерных блоков, МГц",
            "Шейдерных блоков", "TMU", "ROP", "Частота работы памяти (DDR), МГц", "Шина памяти", "Тип памяти",
            "Объем памяти", "DirectX", "Интерфейс", "Энергопотребление, Вт", "Дата выпуска", "Стоимость, $", "Ссылка на яндекс маркет"};

            return _specification;
        }

        public List<string> CreateVideoSpec(VideoCard value)
        {
            _specification = new List<string> { value.name, value.Core, value.technicalProcess, value.transistor, value.frequency,
            value.frequencyShaders, value.ShadersBlocks, value.TMU, value.ROP, value.frequencyMem, value.busMem, value.TypeMem, value.ValueMem,
            value.DirectX, value.Interface, value.energy, value.date, value.price, value.url };

            return _specification;
        }

    }
}
