﻿using System.ServiceModel;
using System.ServiceModel.Web;

namespace CommHub
{
    [ServiceContract]
    public interface IService
    {
        #region AdminComm
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "AdminComm_Del")]
        wsResponse<AdminComm_Del_Resp> AdminComm_Del(wsRequest<InstanceID> req);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "AdminComm_ReadDict")]
        wsResponse<AdminComm_ReadDict_Resp> AdminComm_ReadDict(wsRequest req);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "AdminComm_Save")]
        wsResponse<AdminComm_Save_Resp> AdminComm_Save(wsRequest<AdminComm_Save_Req> req);
        #endregion

        #region OwnerHub
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "OwnerHub_Save")]
        wsResponse OwnerHub_Save(wsRequest<OwnerHub_Save_Req> req);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "OwnerHub_Read")]
        wsResponse<OwnerHub_Read_Resp> OwnerHub_Read(wsRequest req);
        #endregion

        #region Comm
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "Comm_Del")]
        wsResponse Comm_Del(wsRequest<InstanceID> req);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "Comm_ReadDict")]
        wsResponse<Comm_ReadDict_Resp> Comm_ReadDict(wsRequest req);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "Comm_Save")]
        wsResponse Comm_Save(wsRequest<Comm_Save_Req> req);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "Comm_Read")]
        wsResponse<Comm_Read_Resp> Comm_Read(wsRequest<InstanceID> req);
        #endregion

        #region ProjectHub
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "ProjectHub_Del")]
        wsResponse ProjectHub_Del(wsRequest<InstanceID> req);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "ProjectHub_ReadDict")]
        wsResponse<ProjectHub_ReadDict_Resp> ProjectHub_ReadDict(wsRequest req);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "ProjectHub_Save")]
        wsResponse ProjectHub_Save(wsRequest<ProjectHub_Save_Req> req);
        #endregion

        #region StaComm
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "StaCommDaily_Report")]
        wsResponse<StaComm_Report_Resp> StaCommDaily_Report(wsRequest<StaCommDaily_Report_Req> req);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "StaCommVKDaily_Report")]
        wsResponse<StaCommVK_Report_Resp> StaCommVKDaily_Report(wsRequest<StaCommDaily_Report_Req> req);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "StaCommVKWeekly_Report")]
        wsResponse<StaCommVK_Report_Resp> StaCommVKWeekly_Report(wsRequest req);
        #endregion

        #region StaCommGraph
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "StaCommVKGraph_Report")]
        wsResponse<StaCommVKGraph_Report_Resp> StaCommVKGraph_Report(wsRequest<StaCommVKGraph_Report_Req> req);
        #endregion

        #region StaCommOK
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "StaCommOKDaily_Report")]
        wsResponse<StaCommOK_Report_Resp> StaCommOKDaily_Report(wsRequest<StaCommDaily_Report_Req> req);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "StaCommOKWeekly_Report")]
        wsResponse<StaCommOK_Report_Resp> StaCommOKWeekly_Report(wsRequest req);
        #endregion

        #region SubjectComm
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "SubjectComm_Del")]
        wsResponse SubjectComm_Del(wsRequest<InstanceID> req);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "SubjectComm_ReadDict")]
        wsResponse<SubjectComm_ReadDict_Resp> SubjectComm_ReadDict(wsRequest req);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "SubjectComm_Save")]
        wsResponse<SubjectComm_Save_Resp> SubjectComm_Save(wsRequest<SubjectComm_Save_Req> req);
        #endregion   

        #region Session
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "SessionReq_Save")]
        wsResponse<SessionReq_Save_Resp> SessionReq_Save(SessionReq_Save_Req req);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "Session_Save")]
        wsResponse<Session_Save_Resp> Session_Save(Session_Save_Req req);
        #endregion
    }
}
