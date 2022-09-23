using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Game
    {
        public int id { get; set; }
        public string tournament_name { get; set; }
        public DateTime date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                DB db = new DB();
                db.ChangeData($"UPDATE `game` SET `date` = '{value}' WHERE `game`.`id` = {id}");
            }
        }
        public bool isFinished { get; set; }
    }
}
