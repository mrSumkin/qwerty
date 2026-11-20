using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020004EB RID: 1259
[eiz("SIAAP3")]
[Serializable]
public sealed class ekg : cdg, ISerializable
{
	// Token: 0x06002084 RID: 8324 RVA: 0x000B0058 File Offset: 0x000AE258
	private ekg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("SIAAP3:C", typeof(Color?)) as Color?);
	}

	// Token: 0x06002085 RID: 8325 RVA: 0x000B0088 File Offset: 0x000AE288
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SIAAP3:C", this.a);
	}

	// Token: 0x06002086 RID: 8326 RVA: 0x000B00A8 File Offset: 0x000AE2A8
	public Color? a()
	{
		return this.a;
	}

	// Token: 0x06002087 RID: 8327 RVA: 0x000B00B0 File Offset: 0x000AE2B0
	public void a(Color? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002088 RID: 8328 RVA: 0x000B00BC File Offset: 0x000AE2BC
	public ekg()
	{
	}

	// Token: 0x06002089 RID: 8329 RVA: 0x000B00C4 File Offset: 0x000AE2C4
	protected override void ah6(x4 A_0)
	{
		A_0.a(this.a);
	}

	// Token: 0x0400141A RID: 5146
	private Color? a;
}
