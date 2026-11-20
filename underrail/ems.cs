using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.CustomLogic.Data;

// Token: 0x020007B9 RID: 1977
[eiz("SPHESC")]
[Serializable]
public sealed class ems : esc, ISerializable
{
	// Token: 0x06003180 RID: 12672 RVA: 0x0012F750 File Offset: 0x0012D950
	private ems(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (PlayerHouseElement)A_0.GetValue("SPHESC:E", typeof(PlayerHouseElement));
		this.b = A_0.GetString("SPHESC:V");
	}

	// Token: 0x06003181 RID: 12673 RVA: 0x0012F78C File Offset: 0x0012D98C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SPHESC:E", this.a);
		info.AddValue("SPHESC:V", this.b);
	}

	// Token: 0x06003182 RID: 12674 RVA: 0x0012F7C0 File Offset: 0x0012D9C0
	public PlayerHouseElement b()
	{
		return this.a;
	}

	// Token: 0x06003183 RID: 12675 RVA: 0x0012F7C8 File Offset: 0x0012D9C8
	public void a(PlayerHouseElement A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003184 RID: 12676 RVA: 0x0012F7D4 File Offset: 0x0012D9D4
	public string a()
	{
		return this.b;
	}

	// Token: 0x06003185 RID: 12677 RVA: 0x0012F7DC File Offset: 0x0012D9DC
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06003186 RID: 12678 RVA: 0x0012F7E8 File Offset: 0x0012D9E8
	public ems()
	{
	}

	// Token: 0x06003187 RID: 12679 RVA: 0x0012F7F0 File Offset: 0x0012D9F0
	public override int d5(bq8 A_0, bq8 A_1)
	{
		new dhi(this.a, this.b).ym(null, null, null);
		return 0;
	}

	// Token: 0x04001AB2 RID: 6834
	private PlayerHouseElement a;

	// Token: 0x04001AB3 RID: 6835
	private string b;
}
