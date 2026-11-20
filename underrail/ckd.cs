using System;
using System.Runtime.Serialization;

// Token: 0x020005EE RID: 1518
[eiz("JOC")]
[Serializable]
public sealed class ckd : dth, ISerializable, y9
{
	// Token: 0x060027DA RID: 10202 RVA: 0x000E6F24 File Offset: 0x000E5124
	private ckd(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("JOC:C");
	}

	// Token: 0x060027DB RID: 10203 RVA: 0x000E6F40 File Offset: 0x000E5140
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("JOC:C", this.a);
	}

	// Token: 0x060027DC RID: 10204 RVA: 0x000E6F54 File Offset: 0x000E5154
	public string a()
	{
		return this.a;
	}

	// Token: 0x060027DD RID: 10205 RVA: 0x000E6F5C File Offset: 0x000E515C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060027DE RID: 10206 RVA: 0x000E6F68 File Offset: 0x000E5168
	public ckd()
	{
	}

	// Token: 0x060027DF RID: 10207 RVA: 0x000E6F74 File Offset: 0x000E5174
	public bool jh(object A_0)
	{
		if (!string.IsNullOrEmpty(this.a) && !dk2.b(this.a))
		{
			return false;
		}
		ll ll = A_0 as ll;
		if (ll != null)
		{
			return ll.a() != null && euf.t(ll.a());
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().Vehicle != null && (serviceOrThrow.aqu().v().Vehicle.y() == bws.b || serviceOrThrow.aqu().v().Vehicle.y() == bws.a))
		{
			ak1 ak = A_0 as ak1;
			return ak == null || !aw1.a(ak, true, null, l9.b);
		}
		return false;
	}

	// Token: 0x060027E0 RID: 10208 RVA: 0x000E7054 File Offset: 0x000E5254
	public string ji()
	{
		return null;
	}

	// Token: 0x060027E1 RID: 10209 RVA: 0x000E7058 File Offset: 0x000E5258
	public string jj()
	{
		return "при езде на гидроцикле";
	}

	// Token: 0x04001646 RID: 5702
	private string a;
}
