Public Class Constant

    'バリデーションメッセージ
    Public Const INVALID_USERNAME_LENGTH As String = "ユーザ名は1～255文字で指定してください。"
    Public Const INVALID_PASSWORD_LENGTH As String = "パスワードは1～255文字で指定してください。"
    Public Const INVALID_PROJECTNAME_LENGTH As String = "プロジェクト名は1～255文字で指定してください。"
    Public Const INVALID_SUMMARY_LENGTH As String = "概要は1～255文字で指定してください。"
    Public Const INVALID_TASKNAME_LENGTH As String = "タスク名は1～255文字で指定してください。"
    Public Const INVALID_WIKI_LENGTH As String = "Wikiは1～1000文字で指定してください。"
    Public Const HOUR_MUST_INPUT As String = "工数は必須項目です。"
    Public Const START_DATE_MUST_INPUT As String = "開始日時は必須項目です。"
    Public Const END_DATE_MUST_INPUT As String = "終了日時は必須項目です。"
    Public Const STATUS_MUST_INPUT As String = "状態は必須項目です。"
    Public Const PROJECTNAME_MUST_INPUT As String = "プロジェクト名は必須項目です。"
    Public Const START_DATE_MUST_BEFORE_END_DATE As String = "開始日時は終了日時より前でなければいけません。"
    Public Const STATUS_MUST_IN_CMB As String = "状態はコンボボックスから選択してください。"
    Public Const PROJECTNAME_MUST_IN_CMB As String = "プロジェクト名はコンボボックスから選択してください。"
    '失敗メッセージ
    Public Const FAILED_LOGIN As String = "ログインに失敗しました。"
    Public Const FAILED_INSERT_PROJECT As String = "プロジェクト登録に失敗しました。"
    Public Const FAILED_DELETE_PROJECT As String = "プロジェクト削除に失敗しました。"
    Public Const FAILED_UPDATE_PROJECT As String = "プロジェクト更新に失敗しました。"
    Public Const FAILED_INSERT_TASK As String = "タスク登録に失敗しました。"
    Public Const FAILED_DELETE_TASK As String = "タスク削除に失敗しました。"
    Public Const FAILED_UPDATE_TASK As String = "タスク更新に失敗しました。"
    Public Const FAILED_OUTPUT_CSV As String = "CSV出力に失敗しました。"
    Public Const FAILED_REQUEST_PROJECT As String = "プロジェクト応募に失敗しました。"
    Public Const FAILED_UPDATE_WIKI As String = "Wiki更新に失敗しました。"
    '成功メッセージ
    Public Const SUCCESS_INSERT_PROJECT As String = "プロジェクト登録に成功しました。"
    Public Const SUCCESS_DELETE_PROJECT As String = "プロジェクト削除に成功しました。"
    Public Const SUCCESS_UPDATE_PROJECT As String = "プロジェクト更新に成功しました。"
    Public Const SUCCESS_INSERT_TASK As String = "タスク登録に成功しました。"
    Public Const SUCCESS_UPDATE_TASK As String = "タスク更新に成功しました。"
    Public Const SUCCESS_OUTPUT_CSV As String = "CSV出力に成功しました。"
    Public Const SUCCESS_REQUEST_PROJECT As String = "プロジェクト応募に成功しました。"
    Public Const SUCCESS_UPDATE_WIKI As String = "Wiki更新に成功しました。"
    '接続文字列
    Public Const CONNECTION_STRING As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=testDB4;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    'メッセージタイトル
    Public Const WARNING As String = "警告"
    Public Const CONFIRM As String = "確認"
    '最大文字数
    Public Const USERNAME_MAX_LENGTH As Long = 255
    Public Const PASSWORD_MAX_LENGTH As Long = 255
    Public Const PROJECTNAME_MAX_LENGTH As Long = 255
    Public Const SUMMARY_MAX_LENGTH As Long = 255
    Public Const TASKNAME_MAX_LENGTH As Long = 255
    Public Const WIKI_MAX_LENGTH As Long = 1000
    'その他
    Public Const LOCK_COUNT As Long = 3
    Public Const USER_IS_LOCKED As String = "アカウントがロックされています。管理者に問い合わせてください。"
    Public Const USER_IS_LOCK As String = "アカウントがロックされました。管理者に問い合わせてください。"
    Public Const OUTPUT_CSV_PATH = "C:\Users\PC01\Desktop"
    'SQL
    Public Const GET_USER_COUNT_SQL As String = "SELECT " +
                                                "  COUNT(*) " +
                                                "FROM " +
                                                "  Users " +
                                                "WHERE " +
                                                "  UserName = @UserName " +
                                                "AND " +
                                                "  Password = @Password "
    Public Const GET_USERID_SQL As String = "SELECT " +
                                            "  Id " +
                                            "FROM " +
                                            "  Users " +
                                            "WHERE " +
                                            "  UserName = @UserName " +
                                            "AND " +
                                            "  Password = @Password "
    Public Const UPDATE_LOCKFLAG_SQL As String = "UPDATE " +
                                                "   Users " +
                                                " SET " +
                                                "   LockFlag = @LockFlag " +
                                                " WHERE " +
                                                "   UserName = @UserName "
    Public Const GET_USERNAME_COUNT_SQL As String = "SELECT " +
                                                    "  COUNT(*) " +
                                                    "FROM " +
                                                    "  Users " +
                                                    "WHERE " +
                                                    "  UserName = @UserName "
    Public Const GET_LOCKFLAG_SQL As String = "SELECT " +
                                            "    LockFlag " +
                                            "  FROM " +
                                            "    Users " +
                                            "  WHERE " +
                                            "    UserName = @UserName "
    Public Const GET_USERNAME_SQL As String = "SELECT " +
                                            "    UserName " +
                                            "  FROM " +
                                            "    Users " +
                                            "  WHERE " +
                                            "    Id = @Id "
    Public Const GET_ADMIN_SQL As String = " SELECT " +
                                            "  Admin " +
                                            "FROM " +
                                            "  Users " +
                                            "WHERE " +
                                            "  Id = @Id "
    Public Const GET_LOCKED_USERS_SQL As String = "SELECT " +
                                                "    Id, " +
                                                "    UserName, " +
                                                "    Password " +
                                                "  FROM " +
                                                "    Users " +
                                                "  WHERE " +
                                                "    LockFlag = @LockFlag " +
                                                "  ORDER BY " +
                                                "    Id ASC "
    Public Const INSERT_PROJECT_SQL As String = " INSERT " +
                                                "   INTO " +
                                                " Projects " +
                                                "   (ProjectName, " +
                                                "   Hour, " +
                                                "   Summary, " +
                                                "   StartDate, " +
                                                "   EndDate, " +
                                                "   Status, " +
                                                "   Notification_Flag, " +
                                                "   Display_Flag) " +
                                                " VALUES" +
                                                "   (@ProjectName, " +
                                                "   @Hour, " +
                                                "   @Summary, " +
                                                "   @StartDate, " +
                                                "   @EndDate, " +
                                                "   @Status, " +
                                                "   @Notification_Flag, " +
                                                "   @Display_Flag) "
    Public Const GET_PROJECTS_SQL As String = " SELECT " +
                                            "     Id, " +
                                            "     ProjectName, " +
                                            "     Hour, " +
                                            "     Summary, " +
                                            "     StartDate, " +
                                            "     EndDate, " +
                                            "     Status " +
                                            "   FROM " +
                                            "     Projects " +
                                            "   WHERE " +
                                            "     Display_Flag = @Display_Flag "
    Public Const GET_PROJECTID_SQL As String = " SELECT " +
                                            "      Id " +
                                            "    FROM " +
                                            "      Projects " +
                                            "    WHERE " +
                                            "      ProjectName = @ProjectName "
    Public Const DELETE_PROJECT_SQL As String = "DELETE " +
                                                "FROM " +
                                                "  Projects " +
                                                "WHERE " +
                                                "  Id = @Id "
    Public Const GET_PROJECT_SQL As String = " SELECT " +
                                            "    Id, " +
                                            "    ProjectName, " +
                                            "    Hour, " +
                                            "    Summary, " +
                                            "    StartDate, " +
                                            "    EndDate, " +
                                            "    Status " +
                                            "   FROM " +
                                            "     Projects " +
                                            "   WHERE " +
                                            "     Id = @Id "
    Public Const GET_PROJECTWIKI_SQL As String = " SELECT " +
                                                "    Wiki " +
                                                "  FROM " +
                                                "    Projects " +
                                                "  WHERE " +
                                                "    Id = @Id "
    Public Const GET_SUM_PROJECT_HOURS_SQL As String = " SELECT " +
                                                    "      SUM(Hour) " +
                                                    "    FROM " +
                                                    "      Tasks " +
                                                    "    WHERE " +
                                                    "      Project_Id = @Project_Id "
    Public Const GET_TODAY_PROJECT_COUNT_SQL As String = " SELECT " +
                                                        "    COUNT(*) " +
                                                        "  FROM " +
                                                        "    Projects " +
                                                        "  WHERE " +
                                                        "    EndDate = @EndDate " +
                                                        "  AND " +
                                                        "    Notification_Flag = @Notification_Flag "
    Public Const GET_TODAY_PROJECT_SQL As String = " SELECT " +
                                                    "  ProjectName " +
                                                    "FROM " +
                                                    "  Projects " +
                                                    "WHERE " +
                                                    "  EndDate = @EndDate " +
                                                    "AND " +
                                                    "  Notification_Flag = @Notification_Flag "
    Public Const UPDATE_PROJECT_SQL As String = "UPDATE " +
                                                "  Projects " +
                                                "SET " +
                                                "  ProjectName = @ProjectName, " +
                                                "  Hour = @Hour, " +
                                                "  Summary = @Summary, " +
                                                "  StartDate = @StartDate, " +
                                                "  EndDate = @EndDate, " +
                                                "  Status = @Status " +
                                                "WHERE " +
                                                "  Id = @Id "
    Public Const UPDATE_PROJECTWIKI_SQL As String = "UPDATE " +
                                                    "  Projects " +
                                                    "SET " +
                                                    "  Wiki = @Wiki " +
                                                    "WHERE " +
                                                    "  Id = @Id "
    Public Const UPDATE_ALL_PROJECT_NORTICATION_SQL As String = "UPDATE " +
                                                                "  Projects " +
                                                                "SET " +
                                                                "  Notification_Flag = @Notification_Flag "
    Public Const INSERT_TASK_SQL As String = "INSERT " +
                                            "   INTO " +
                                            " Tasks " +
                                            "   (TaskName, " +
                                            "   Hour, " +
                                            "   Summary, " +
                                            "   InsertDate, " +
                                            "   UpdateDate, " +
                                            "   Status, " +
                                            "   Display_Flag, " +
                                            "   Project_Id) " +
                                            " VALUES" +
                                            "   (@TaskName, " +
                                            "   @Hour, " +
                                            "   @Summary, " +
                                            "   @InsertDate, " +
                                            "   @UpdateDate, " +
                                            "   @Status, " +
                                            "   @Display_Flag, " +
                                            "   @Project_Id) "
    Public Const GET_TASKS_SQL As String = " SELECT " +
                                            "  Id, " +
                                            "  TaskName, " +
                                            "  Hour, " +
                                            "  Summary, " +
                                            "  InsertDate, " +
                                            "  UpdateDate, " +
                                            "  Status " +
                                            "FROM " +
                                            "  Tasks " +
                                            "WHERE " +
                                            "  Project_Id = @Project_Id " +
                                            "AND " +
                                            "  Display_Flag = @Display_Flag "
    Public Const DELETE_TASK_SQL As String = "DELETE " +
                                            " FROM " +
                                            "   Tasks " +
                                            " WHERE " +
                                            "   Id = @Id "
    Public Const GET_TASK_SQL As String = " SELECT " +
                                        "     Id, " +
                                        "     TaskName, " +
                                        "     Hour, " +
                                        "     Summary, " +
                                        "     InsertDate, " +
                                        "     UpdateDate, " +
                                        "     Status " +
                                        "   FROM " +
                                        "     Tasks " +
                                        "   WHERE " +
                                        "     Id = @Id "
    Public Const UPDATE_TASK_SQL As String = "UPDATE " +
                                            "   Tasks " +
                                            " SET " +
                                            "   TaskName = @TaskName, " +
                                            "   Hour = @Hour, " +
                                            "   Summary = @Summary, " +
                                            "   UpdateDate = @UpdateDate, " +
                                            "   Status = @Status " +
                                            "WHERE " +
                                            "  Id = @Id "
    Public Const GET_TASK_SEARCH_COUNT_SQL = " SELECT " +
                                        "   COUNT(*) " +
                                        " FROM " +
                                        "   Tasks " +
                                        " WHERE " +
                                        "   Project_Id = @Project_Id " +
                                        " AND " +
                                        "   TaskName Like @TaskName "
    Public Const GET_SEARCH_TASK_SQL = "  SELECT " +
                                        "   Id, " +
                                        "   TaskName, " +
                                        "   Hour, " +
                                        "   Summary, " +
                                        "   InsertDate, " +
                                        "   UpdateDate, " +
                                        "   Status " +
                                        " FROM " +
                                        "   Tasks " +
                                        " WHERE " +
                                        "   Project_Id = @Project_Id " +
                                        " AND " +
                                        "   TaskName Like @TaskName "
    Public Const GET_SORTED_TASKS_SQL As String = " SELECT " +
                                                "     Id, " +
                                                "     TaskName, " +
                                                "     Hour, " +
                                                "     Summary, " +
                                                "     InsertDate, " +
                                                "     UpdateDate, " +
                                                "     Status " +
                                                "   FROM " +
                                                "     Tasks " +
                                                "   WHERE " +
                                                "     Project_Id = @Project_Id " +
                                                "   AND " +
                                                "     Display_Flag = @Display_Flag " +
                                                "   ORDER BY Status DESC "
    Public Const UPDATE_DISPLAY_FLAG_SQL As String = "UPDATE " +
                                                    "   Tasks " +
                                                    " SET " +
                                                    "   Display_Flag = @Display_Flag " +
                                                    " WHERE " +
                                                    "   Id = @Id "
    Public Const GET_ARCHIVED_TASKS_SQL As String = " SELECT " +
                                                    "   Id, " +
                                                    "   TaskName, " +
                                                    "   Hour, " +
                                                    "   Summary, " +
                                                    "   InsertDate, " +
                                                    "   UpdateDate, " +
                                                    "   Status " +
                                                    " FROM " +
                                                    "   Tasks " +
                                                    " WHERE " +
                                                    "   Display_Flag = @Display_Flag "
    Public Const INSERT_REQUEST_SQL As String = " INSERT " +
                                                "   INTO " +
                                                " Requests " +
                                                "   (Project_Id, " +
                                                "   User_Id, " +
                                                "   ProjectName, " +
                                                "   IsNotification) " +
                                                " VALUES" +
                                                "   (@Project_Id, " +
                                                "   @User_Id, " +
                                                "   @ProjectName, " +
                                                "   @IsNotification) "
    Public Const GET_REQUEST_COUNT_SQL As String = "SELECT " +
                                                "     COUNT(*) " +
                                                "   FROM " +
                                                "     Requests " +
                                                "   WHERE " +
                                                "     IsNotification = @IsNotification "
    Public Const GET_NOT_NOTIFIED_REQUEST_SQL As String = "SELECT " +
                                                        "    User_Id, " +
                                                        "    ProjectName " +
                                                        "  FROM " +
                                                        "    Requests " +
                                                        "  WHERE " +
                                                        "    IsNotification = @IsNotification "
    Public Const UPDATE_ALL_NOTIFICATION_SQL As String = "UPDATE " +
                                                        "   Requests " +
                                                        " SET " +
                                                        "   IsNotification = @IsNotification "
End Class
