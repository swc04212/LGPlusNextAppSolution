﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGUPlusCommon
{
    public class UserServices
    {
        public UserServices()
        { 
            
        }
        /// <summary>
        /// 사용자 정보등록 공통 메소드
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string SaveUserData(UserModel user) 
        {
            Debug.WriteLine($"입력 사용자 이름은 {user.UserName}입니다.");
            return "OK";
        }

        /// <summary>
        /// 단일 사용자 정보 조회
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserModel GetUserData(string userId)
        {
            UserModel user = new UserModel();
            user.UserName = "김유진";
            user.UserEmail = "swc04212@naver.com";

            return user;
        }
    }
}
