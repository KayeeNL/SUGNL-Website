// /*===========================================================
//    Copyright 2013 Robbert Hock
//  
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//  
// ============================================================*/

using System.Collections.Generic;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Glass.Sitecore.Mapper.FieldTypes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface IMeetingDetails
    {
        [SitecoreField(FieldName = "Location")]
        string Location { get; set; }

        [SitecoreField(FieldName = "Topics")]
        string Topics { get; set; }

        [SitecoreField(FieldName = "Speakers")]
        IEnumerable<PersonModel> Speakers { get; set; }

        [SitecoreField(FieldName = "Organizer Logo")]
        Image OrganizerLogo { get; set; }

        [SitecoreField(FieldName = "Attending Title")]
        string AttendingTitle { get; set; }

        [SitecoreField(FieldName = "Attending Intro")]
        string AttendingIntro { get; set; }

        [SitecoreField(FieldName = "Attending Url")]
        Link AttendingUrl { get; set; }
    }
}