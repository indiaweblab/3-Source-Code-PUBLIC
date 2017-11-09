﻿using System;
using System.Collections.Generic;
using System.Text;
using Suzsoft.Smart.EntityCore;

namespace eContract.Common.Schema
{
    [Serializable]
    public partial class CasContractApproverTable : TableInfo
    {
        public const string C_TableName = "CAS_CONTRACT_APPROVER";

        public const string C_CONTRACT_APPROVER_ID = "CONTRACT_APPROVER_ID";

        public const string C_CONTRACT_ID = "CONTRACT_ID";

        public const string C_CONTRACT_APPROVAL_STEP_ID = "CONTRACT_APPROVAL_STEP_ID";

        public const string C_APPROVER_ID = "APPROVER_ID";

        public const string C_APPROVER_TYPE = "APPROVER_TYPE";

        public const string C_STATUS = "STATUS";

        public const string C_IS_DELETED = "IS_DELETED";

        public const string C_CREATED_BY = "CREATED_BY";

        public const string C_CREATE_TIME = "CREATE_TIME";

        public const string C_LAST_MODIFIED_BY = "LAST_MODIFIED_BY";

        public const string C_LAST_MODIFIED_TIME = "LAST_MODIFIED_TIME";


        public CasContractApproverTable()
        {
            _tableName = "CAS_CONTRACT_APPROVER";
        }

        protected static CasContractApproverTable _current;
        public static CasContractApproverTable Current
        {
            get
            {
                if (_current == null)
                {
                    Initial();
                }
                return _current;
            }
        }

        private static void Initial()
        {
            _current = new CasContractApproverTable();

            _current.Add(C_CONTRACT_APPROVER_ID, new ColumnInfo(C_CONTRACT_APPROVER_ID, "contract_approver_id", true, typeof(string)));

            _current.Add(C_CONTRACT_ID, new ColumnInfo(C_CONTRACT_ID, "contract_id", false, typeof(string)));

            _current.Add(C_APPROVER_ID, new ColumnInfo(C_APPROVER_ID, "approver_id", false, typeof(string)));

            _current.Add(C_CONTRACT_APPROVAL_STEP_ID, new ColumnInfo(C_CONTRACT_APPROVAL_STEP_ID, "contract_approval_step_id", false, typeof(string)));

            _current.Add(C_APPROVER_TYPE, new ColumnInfo(C_APPROVER_TYPE, "approver_type", false, typeof(int)));

            _current.Add(C_STATUS, new ColumnInfo(C_STATUS, "status", false, typeof(int)));

            _current.Add(C_IS_DELETED, new ColumnInfo(C_IS_DELETED, "is_deleted", false, typeof(bool)));

            _current.Add(C_CREATED_BY, new ColumnInfo(C_CREATED_BY, "created_by", false, typeof(string)));

            _current.Add(C_CREATE_TIME, new ColumnInfo(C_CREATE_TIME, "create_time", false, typeof(DateTime)));

            _current.Add(C_LAST_MODIFIED_BY, new ColumnInfo(C_LAST_MODIFIED_BY, "last_modified_by", false, typeof(string)));

            _current.Add(C_LAST_MODIFIED_TIME, new ColumnInfo(C_LAST_MODIFIED_TIME, "last_modified_time", false, typeof(DateTime)));

        }


        public ColumnInfo CONTRACT_APPROVER_ID
        {
            get { return this[C_CONTRACT_APPROVER_ID]; }
        }

        public ColumnInfo CONTRACT_ID
        {
            get { return this[C_CONTRACT_ID]; }
        }

        public ColumnInfo APPROVER_ID
        {
            get { return this[C_APPROVER_ID]; }
        }

        public ColumnInfo CONTRACT_APPROVAL_STEP_ID
        {
            get { return this[C_CONTRACT_APPROVAL_STEP_ID]; }
        }


        public ColumnInfo APPROVER_TYPE
        {
            get { return this[C_APPROVER_TYPE]; }
        }

        public ColumnInfo STATUS
        {
            get { return this[C_STATUS]; }
        }

        public ColumnInfo IS_DELETED
        {
            get { return this[C_IS_DELETED]; }
        }

        public ColumnInfo CREATED_BY
        {
            get { return this[C_CREATED_BY]; }
        }

        public ColumnInfo CREATE_TIME
        {
            get { return this[C_CREATE_TIME]; }
        }

        public ColumnInfo LAST_MODIFIED_BY
        {
            get { return this[C_LAST_MODIFIED_BY]; }
        }

        public ColumnInfo LAST_MODIFIED_TIME
        {
            get { return this[C_LAST_MODIFIED_TIME]; }
        }

    }
}