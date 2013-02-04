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
using System.Linq;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Glass.Sitecore.Mapper.Razor;
using Sitecore.Configuration;
using Sitecore.Diagnostics;
using Sitecore.Pipelines;

namespace Website.Pipelines
{
    /// <summary>
    /// This InitializeGlassMapper class was introduced by Mike Reynolds.
    /// This class is used to kick-start Sitecore Glass Mapper instead of starting it from global.asax when the application starts.
    /// More info: http://sitecorejunkie.com/2013/02/01/kick-start-glass-sitecore-mapper-in-a-sitecore-initialize-pipeline/
    /// Old way:
    /// var loader = new AttributeConfigurationLoader("Website.MVC, SUGNL.Website");
    /// var context = new Context(loader, new GlassModuleLoader());
    /// I adjusted the code a little bit to pass in the GlassModuleLoader, else we get the following exception in the backend:
    /// Exception: Glass.Sitecore.Mapper.MapperException
    /// Message: Type Glass.Sitecore.Mapper.Razor.Model.GlassRazorFolder has not been loaded
    /// Source: Glass.Sitecore.Mapper
    /// </summary>
    public class InitializeGlassMapper
    {
        public void Process(PipelineArgs args)
        {
            CreateContextIfApplicable(GetModelTypes());
        }

        private static void CreateContextIfApplicable(IEnumerable<string> modelTypes)
        {
            if (CanCreateContext(modelTypes))
            {
                CreateContext(CreateNewAttributeConfigurationLoader(modelTypes));
            }
        }

        private static bool CanCreateContext(IEnumerable<string> modelTypes)
        {
            return modelTypes != null && modelTypes.Any();
        }

        private static AttributeConfigurationLoader CreateNewAttributeConfigurationLoader(IEnumerable<string> modelTypes)
        {
            Assert.ArgumentNotNull(modelTypes, "modelTypes");
            Assert.ArgumentCondition(modelTypes.Any(), "modelTypes", "modelTypes collection must contain at least one string!");
            return new AttributeConfigurationLoader(modelTypes.ToArray());
        }

        private static void CreateContext(AttributeConfigurationLoader loader)
        {
            Assert.ArgumentNotNull(loader, "loader");
            var context = new Glass.Sitecore.Mapper.Context(loader, new GlassModuleLoader());
        }

        private static IEnumerable<string> GetModelTypes()
        {
            return Factory.GetStringSet("glassMapperModels/type");
        }
    }
}