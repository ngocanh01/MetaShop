using MetaShop.Common.Dtos;
using MetaShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.Business
{
    internal class AutoMapperProfile : AutoMapper.Profile
    {
        internal AutoMapperProfile()
        {
            FromDataAccessorLayer();
            FromPresentationLayer();
        }

        private void FromPresentationLayer()
        {
        }

        private void FromDataAccessorLayer()
        {
            CreateMap<MetaShop.DAL.Entities.Attribute, AttributeDto>();
        }
    }
}
