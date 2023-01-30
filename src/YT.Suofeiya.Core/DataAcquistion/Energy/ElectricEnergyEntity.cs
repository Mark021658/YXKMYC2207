using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.DataAcquistion.Energy
{
    public class ElectricEnergyEntity : Entity, IHasCreationTime
    {
        //[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]  //设置自增
        //public int EnertyIndex { get; set; }             //自增
        public DateTime CreationTime { get; set; }

        public float AVoltage { get; set; }     //A相电压
        public float BVoltage { get; set; }     //B相电压
        public float CVoltage { get; set; }
        public float ABVoltage { get; set; }
        public float BCVoltage { get; set; }
        public float CAVoltage { get; set; }
        public float AEleCurrent { get; set; }     //A相电流
        public float BEleCurrent { get; set; }     //B相电流
        public float CEleCurrent { get; set; }
        public float AActivePower { get; set; }     //A相有功功率
        public float BActivePower { get; set; }     //B相有功功率
        public float CActivePower { get; set; }
        public float AllActivePower { get; set; }
        public bool IsReport { get; set; }

    }
}
