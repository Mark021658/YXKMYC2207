using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YT.Suofeiya.Order;
using YT.Suofeiya.Order.Dto;

namespace YT.Suofeiya.UI.Page
{
    public partial class PageOrderDataMapping : UserControlBase
    {
        private readonly IDataMappingService _dataMappingService;
        private readonly IDataMappingService _myDataMappingService;

        public PageOrderDataMapping()
        {
            _dataMappingService = IocManager.Instance.Resolve<IDataMappingService>();
            //_myDataMappingService = IocManager.Instance.Resolve<IDataMappingService>(typeof(MyDataMappingService));
            InitializeComponent();

            kcb_fieldType.Items.Add(new ComboBoxItem("[0]来源", 0));
            kcb_fieldType.Items.Add(new ComboBoxItem("[1]目标", 1));
            kcb_fieldType.DisplayMember = ComboBoxItem.NAME;
            kcb_fieldType.ValueMember = ComboBoxItem.VALUE;

            this.refresh();
        }

        public void refresh() {
            List<TaskFieldDto> sourceFieldList = _dataMappingService.GetFieldList(TaskFieldDto.FIELD_TYPE_SOURCE);
            List<TaskFieldDto> destFieldList = _dataMappingService.GetFieldList(TaskFieldDto.FIELD_TYPE_DEST);

            kcb_sourceField.DataSource = sourceFieldList;
            kcb_sourceField.DisplayMember = "Name";
            kcb_sourceField.ValueMember = "Code";
            
            kcb_destField.DataSource = destFieldList;
            kcb_destField.DisplayMember = "Name";
            kcb_destField.ValueMember = "Code";
            

            grid_fields.DataSource = _dataMappingService.GetAllField();

            grid_mapping.DataSource = _dataMappingService.GetAllMapping();

            this.cleanTextBox();
            
        }

        private void cleanTextBox()
        {
            ktb_fieldId.Text = "";
            ktb_fieldName.Text = "";
            ktb_fieldCode.Text = "";

            ktb_mappingId.Text = "";
            ktb_sourceValue.Text = "";
            ktb_destValue.Text = "";
        }

        /// <summary>
        /// 字段维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kb_save_Click(object sender, EventArgs e)
        {
            try 
            {
                string id = ktb_fieldId.Text;
                string name = ktb_fieldName.Text;
                string code = ktb_fieldCode.Text;
                string type = ((ComboBoxItem)kcb_fieldType.SelectedItem).value.ToString();

                if (!id.Equals(""))
                {
                    TaskFieldDto dto = new TaskFieldDto
                    {
                        Id = int.Parse(id),
                        Name = name,
                        Code = code,
                        Type = int.Parse(type)
                    };
                    _dataMappingService.UpdateTaskField(dto);
                }
                else
                {
                    TaskFieldDto dto = new TaskFieldDto
                    {
                        Name = name,
                        Code = code,
                        Type = int.Parse(type)
                    };
                    _dataMappingService.CreateTaskField(dto);

                }

                this.refresh();
            } 
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void kb_refresh_Click(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.refresh();
        }

        /// <summary>
        /// 字段映射维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ktb_mappingId.Text;
                string sourceField = kcb_sourceField.SelectedValue.ToString();
                string sourceValue = ktb_sourceValue.Text;
                string destField = kcb_destField.SelectedValue.ToString();
                string destValue = ktb_destValue.Text;

                if (!id.Equals(""))
                {
                    DataMappingDto dto = new DataMappingDto
                    {
                        Id = int.Parse(id),
                        SourceField = sourceField,
                        SourceValue = sourceValue,
                        DestField = destField,
                        DestValue = destValue
                    };
                    _dataMappingService.UpdateMapping(dto);
                }
                else
                {
                    DataMappingDto dto = new DataMappingDto
                    {
                        SourceField = sourceField,
                        SourceValue = sourceValue,
                        DestField = destField,
                        DestValue = destValue
                    };
                    _dataMappingService.CreateMapping(dto);
                }

                this.refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /// <summary>
        /// 字段表格选中操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grid_fields_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grid_fields.SelectedCells.Count != 0)
                {
                    cleanTextBox();

                    //得到选中行的索引
                    int rowIndex = e.RowIndex;

                    //得到选中行某列的值
                    if (grid_fields.Rows[rowIndex].Cells["Id"].Value != null)
                    {
                        ktb_fieldId.Text = grid_fields.Rows[rowIndex].Cells["Id"].Value.ToString();

                    }
                    if (grid_fields.Rows[rowIndex].Cells["name"].Value != null)
                    {
                        ktb_fieldName.Text = grid_fields.Rows[rowIndex].Cells["name"].Value.ToString();
                    }
                    if (grid_fields.Rows[rowIndex].Cells["code"].Value != null)
                    {
                        ktb_fieldCode.Text = grid_fields.Rows[rowIndex].Cells["code"].Value.ToString();
                    }
                    if (grid_fields.Rows[rowIndex].Cells["type"].Value != null)
                    {
                        string type = grid_fields.Rows[rowIndex].Cells["type"].Value.ToString();
                        kcb_fieldType.SelectedItem = new ComboBoxItem { 
                            value = int.Parse(type)
                        };
                    }
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// 字段映射表格选中操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void grid_mapping_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grid_mapping.SelectedCells.Count != 0)
                {
                    cleanTextBox();

                    //得到选中行的索引
                    int rowIndex = e.RowIndex;

                    //得到选中行某列的值
                    if (grid_mapping.Rows[rowIndex].Cells["mappingId"].Value != null)
                    {
                        ktb_mappingId.Text = grid_mapping.Rows[rowIndex].Cells["mappingId"].Value.ToString();

                    }
                    if (grid_mapping.Rows[rowIndex].Cells["sourceField"].Value != null)
                    {
                        string sourceField = grid_mapping.Rows[rowIndex].Cells["sourceField"].Value.ToString();
                        kcb_sourceField.SelectedItem = new TaskFieldDto { Code = sourceField };
                    }
                    if (grid_mapping.Rows[rowIndex].Cells["sourceValue"].Value != null)
                    {
                        ktb_sourceValue.Text = grid_mapping.Rows[rowIndex].Cells["sourceValue"].Value.ToString();
                    }
                    if (grid_mapping.Rows[rowIndex].Cells["destField"].Value != null)
                    {
                        string destField = grid_mapping.Rows[rowIndex].Cells["destField"].Value.ToString();
                        kcb_destField.SelectedItem = new TaskFieldDto { Code = destField};
                    }
                    if (grid_mapping.Rows[rowIndex].Cells["destValue"].Value != null)
                    {
                        ktb_destValue.Text = grid_mapping.Rows[rowIndex].Cells["destValue"].Value.ToString();
                    }
                }
            }
            catch
            {

            }
        }
    }
}
