﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */

using CatLib.API.Routing;

namespace YourNameSpace
{
    /// <summary>
    /// 用户代码入口
    /// </summary>
    [Routed]
    public class Main
    {
        [Routed("bootstrap://start")]
        public void Bootstrap()
        {
            // called this function after, use App.Make function to get service
            // ex: App.Make<ILogger>().Debug("hello world");
            // all can make service see : http://catlib.io/v1/guide/can-make.html

            // todo: user code here
            UnityEngine.Debug.Log("hello world! user code here!");
            UnityEngine.GameObject.CreatePrimitive(UnityEngine.PrimitiveType.Cube);
        }
    }
}