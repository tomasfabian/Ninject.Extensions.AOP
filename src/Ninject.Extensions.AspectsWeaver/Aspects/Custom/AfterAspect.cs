﻿// #region License
// // 
// // Author: Tomas Fabian <fabian.frameworks@gmail.com>
// // Copyright (c) 2013, Fabian
// // 
// // Licensed under the Apache License, Version 2.0.
// // See the file LICENSE.txt for details.
// // 

using System;
using Ninject.Extensions.AspectsWeaver.Aspects.Contracts;

namespace Ninject.Extensions.AspectsWeaver.Aspects.Custom
{
    public class AfterAspect : AroundAspect
    {
        public AfterAspect(Action<ISuccessArgs> afterAction) 
            : base(null, afterAction)
        {
        }
    }
}