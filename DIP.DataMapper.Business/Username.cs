﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP.DataMapper.Business {
    public struct Username {
        readonly string _username;

        Username(string username) {
            _username = username;
        }
        public static Username FromString(string username) {
            if(string.IsNullOrWhiteSpace(username)) {
                throw new ArgumentNullException("name");
            }
            return new Username(username);
        }

        public string AsString() {
            return _username;
        }
    }
}
