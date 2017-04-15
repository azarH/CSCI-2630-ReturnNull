﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EDeviceClaims.Domain.Models;

namespace EDeviceClaims.WebUi.Models
{
    public class ClaimViewModel
    {
        public Guid Id { get; set; }
        public string PolicyNumber { get; set; }
        public string DeviceName { get; set; }
        public string SerialNumber { get; set; }
        public string Status { get; set; }
        public List<NoteViewModel> Notes { get; set; }

        public ClaimViewModel()
        {
            Notes = new List<NoteViewModel>();
        }

        public ClaimViewModel(ClaimDomainModel domainModel)
        {
            Id = domainModel.Id;
        }
    }
}