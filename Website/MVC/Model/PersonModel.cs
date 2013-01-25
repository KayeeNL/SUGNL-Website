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

using Glass.Sitecore.Mapper.FieldTypes;
using Website.MVC.Model.Base;
using Website.MVC.Model.Interfaces;

namespace Website.MVC.Model
{
    public class PersonModel : BasePageModel, IPerson
    {
        #region IPerson Members

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual Image PersonImage { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string CompanyUrl { get; set; }
        public virtual string LinkedInUrl { get; set; }
        public virtual string TwitterUrl { get; set; }
        public virtual string FacebookUrl { get; set; }
        public virtual string BlogUrl { get; set; }

        #endregion
    }
}