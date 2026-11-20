using System;
using System.Runtime.Serialization;

// Token: 0x02001A40 RID: 6720
[eiz("ASFE")]
[Serializable]
public sealed class eo3 : d3e, ISerializable
{
	// Token: 0x060091C3 RID: 37315 RVA: 0x0039DB40 File Offset: 0x0039BD40
	protected eo3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (eom)A_0.GetValue("ASFE:F", typeof(eom));
	}

	// Token: 0x060091C4 RID: 37316 RVA: 0x0039DB6C File Offset: 0x0039BD6C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ASFE:F", this.a);
	}

	// Token: 0x060091C5 RID: 37317 RVA: 0x0039DB8C File Offset: 0x0039BD8C
	public eom a()
	{
		return this.a;
	}

	// Token: 0x060091C6 RID: 37318 RVA: 0x0039DB94 File Offset: 0x0039BD94
	public void a(eom A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060091C7 RID: 37319 RVA: 0x0039DBA0 File Offset: 0x0039BDA0
	public eo3()
	{
	}

	// Token: 0x060091C8 RID: 37320 RVA: 0x0039DBA8 File Offset: 0x0039BDA8
	public eo3(eom A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060091C9 RID: 37321 RVA: 0x0039DBBC File Offset: 0x0039BDBC
	public override d3e b3()
	{
		eo3 eo = new eo3();
		this.xx(eo);
		return eo;
	}

	// Token: 0x060091CA RID: 37322 RVA: 0x0039DBD8 File Offset: 0x0039BDD8
	protected override void @in(ll A_0)
	{
		A_0.a().bb |= this.a;
	}

	// Token: 0x060091CB RID: 37323 RVA: 0x0039DBF4 File Offset: 0x0039BDF4
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((eo3)A_0).a = this.a;
	}

	// Token: 0x04003839 RID: 14393
	private new eom a;
}
