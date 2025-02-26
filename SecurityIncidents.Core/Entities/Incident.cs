using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityIncidents.Core.Entities
{
    [Table("SecurityIncidents")]
    public class Incident
    {
        [Key]
        [Column("Id")]
        public int Id { get; private set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("attack_method")]
        public string AttackMethod { get; set; }

        [Column("datum")]
        public DateTime datumOfAttack { get; set; }

        [Column("responsible_person")]
        public string responsiblePerson { get; set; }

        [Column("incident_log")]
        public string IndicentLog { get; set; }

        [Column("zero_day_exploit")]
        public bool ZeroDayExploit { get; set; }

        [Column("HowMany")]
        public int HowMany { get; set; }

    }
}
