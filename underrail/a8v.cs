using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000298 RID: 664
[eiz("TA")]
[Serializable]
public sealed class a8v : dvv, ISerializable
{
	// Token: 0x0600136C RID: 4972 RVA: 0x00051308 File Offset: 0x0004F508
	private a8v(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (ar7)A_0.GetValue("TA:ER", typeof(ar7));
			this.b = (Vector3)A_0.GetValue("TA:D", typeof(Vector3));
		}
		else if (base.GetType() == typeof(a8v))
		{
			this.a = (ar7)A_0.GetValue("_EntityReference", typeof(ar7));
			this.b = (Vector3)A_0.GetValue("_Destination", typeof(Vector3));
		}
		else
		{
			this.a = (ar7)A_0.GetValue("TeleportAction+_EntityReference", typeof(ar7));
			this.b = (Vector3)A_0.GetValue("TeleportAction+_Destination", typeof(Vector3));
		}
		if (ell.a() >= 637)
		{
			this.c = A_0.GetBoolean("TA:C");
		}
	}

	// Token: 0x0600136D RID: 4973 RVA: 0x0005142C File Offset: 0x0004F62C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TA:ER", this.a);
		info.AddValue("TA:D", this.b);
		info.AddValue("TA:C", this.c);
	}

	// Token: 0x0600136E RID: 4974 RVA: 0x0005147C File Offset: 0x0004F67C
	private b0b a()
	{
		return this.a.ao();
	}

	// Token: 0x0600136F RID: 4975 RVA: 0x0005148C File Offset: 0x0004F68C
	public a8v(b0b A_0, Vector3 A_1)
	{
		this.a = new ar7(A_0);
		this.b = A_1;
	}

	// Token: 0x06001370 RID: 4976 RVA: 0x000514A8 File Offset: 0x0004F6A8
	protected override dc4 dt()
	{
		return dc4.b;
	}

	// Token: 0x06001371 RID: 4977 RVA: 0x000514AC File Offset: 0x0004F6AC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a() == null)
		{
			return dc4.e;
		}
		if (this.c)
		{
			this.a().ajo();
		}
		this.a().Location = this.b;
		this.a().ah();
		return dc4.c;
	}

	// Token: 0x04000A97 RID: 2711
	private new ar7 a;

	// Token: 0x04000A98 RID: 2712
	private Vector3 b;

	// Token: 0x04000A99 RID: 2713
	public bool c;
}
