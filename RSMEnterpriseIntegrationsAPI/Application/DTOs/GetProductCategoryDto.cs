﻿namespace RSMEnterpriseIntegrationsAPI.Application.DTOs
{
    public class GetProductCategoryDto
    {
        public int ProductCategoryID { get; set; }
        public string Name { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
