
using PENet;
using PEProtocol;

/// <summary>
/// 文件：ClientSession.cs
/// 功能：客户端网络会话
/// </summary>
public class ClientSession : PESession<GameMsg>
{
    protected override void OnConnected() {
        GameRoot.AddTips("连接服务器成功");
        PECommon.Log("Connect To Server Succ");
    }

    protected override void OnReciveMsg(GameMsg msg)
    {
        PECommon.Log("RcvPack CMD:" + ((CMD)msg.cmd).ToString());
        NetSvc.Instance.AddNetPkg(msg);
    }

    protected override void OnDisConnected()
    {
        GameRoot.AddTips("服务器断开连接");
        PECommon.Log("DisConnect To Server");
    }
}