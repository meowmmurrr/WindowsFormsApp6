namespace WindowsFormsApp6.Акатова
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_1
    {
        public short? Expr1 { get; set; }

        public short? Expr2 { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Expr3 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Expr4 { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Expr5 { get; set; }

        public int? Expr6 { get; set; }

        public int? Expr7 { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Expr8 { get; set; }

        [StringLength(260)]
        public string Expr9 { get; set; }
    }
}
