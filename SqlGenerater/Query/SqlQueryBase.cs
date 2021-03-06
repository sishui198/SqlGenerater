﻿/**
 * Copyright (c) 2015, Harry CU 邱允根 (292350862@qq.com).
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using SqlGenerater.Parser.Parts;
using SqlGenerater.Utils;

namespace SqlGenerater.Query
{
    public abstract class SqlQueryBase
    {
        private readonly ISqlDriver _driver;

        internal ISqlDriver Driver
        {
            get { return _driver; }
        }

        internal Select SelectPart { get; set; }
        internal Select ParentSelectPart { get; set; }

        protected SqlQueryBase(ISqlDriver driver)
        {
            Assert.CheckArgument(driver, "driver");
            _driver = driver;
            SelectPart = null;
            ParentSelectPart = null;
        }
    }
}
