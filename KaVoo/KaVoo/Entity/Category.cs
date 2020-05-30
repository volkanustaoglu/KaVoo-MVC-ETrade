using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KaVoo.Entity
{
    public class Category
    {
        public int Id { get; set; }

        [DisplayName("Kategori Adı")]
        [StringLength(maximumLength: 30, ErrorMessage = "en fazla 30 karakter girebilirsiniz.")]
        public string Name { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        public List<Psikolog> Psikologlar { get; set; }
    }
}