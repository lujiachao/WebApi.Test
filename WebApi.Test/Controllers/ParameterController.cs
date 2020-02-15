using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using WebApi.Test.Models;

namespace WebApi.Test.Controllers
{
    /// <summary>
    /// 该控制器用于测试webapi接受不同格式的参数
    /// </summary>
    [ApiController]
    public class ParameterController : ControllerBase
    {
        /// <summary>
        /// 实体类作为参数测试
        /// </summary>
        [HttpPost]
        [Route("api/test/postpostentity")]
        public Student PostEntityClass(Student student)
        {
            return student;
        }

        /// <summary>
        /// dynamic动态类型
        /// </summary>
        [HttpPost]
        [Route("api/test/postdynamic")]
        public dynamic PostDynamic(dynamic dy)
        {
            var name = dy.name;
            var age = dy.age;
            return dy;
        }

        /// <summary>
        /// JObject参数
        /// </summary>
        [HttpPost]
        [Route("api/test/postjobject")]
        public JObject PostJobject(JObject jo)
        {
            var name = jo["name"];
            var age = jo["age"];
            Console.WriteLine(name);
            return jo;
        }

        /// <summary>
        /// 单参数传值
        /// </summary>
        [HttpPost]
        [Route("api/test/postsingle")]
        public string PostSingle(string value)
        {
            return value;
        }

        /// <summary>
        /// 字典传参
        /// </summary>
        [HttpPost]
        [Route("api/test/postdic")]
        public SortedDictionary<string,string> PostDic(SortedDictionary<string,string> sd)
        {
            return sd;
        }

        /// <summary>
        /// 集合传参
        /// </summary>
        [HttpPost]
        [Route("api/test/postlist")]
        public List<Student> PostList(List<Student> ls)
        {
            return ls;
        }
    }
}
