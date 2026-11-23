using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200110D RID: 4365
[eiz("ZTJ")]
[Serializable]
public sealed class e68 : cze, ISerializable
{
	// Token: 0x06005CB5 RID: 23733 RVA: 0x00279698 File Offset: 0x00277898
	private e68(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("ZTJ:D", typeof(c2w)) as c2w);
		if (ell.a() >= 216)
		{
			this.b = A_0.GetInt32("ZTJ:S");
		}
	}

	// Token: 0x06005CB6 RID: 23734 RVA: 0x002796F8 File Offset: 0x002778F8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ZTJ:D", this.a);
		info.AddValue("ZTJ:S", this.b);
	}

	// Token: 0x170001BE RID: 446
	// (get) Token: 0x06005CB7 RID: 23735 RVA: 0x00279724 File Offset: 0x00277924
	// (set) Token: 0x06005CB8 RID: 23736 RVA: 0x0027972C File Offset: 0x0027792C
	public c2w Destination
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x170001BF RID: 447
	// (get) Token: 0x06005CB9 RID: 23737 RVA: 0x00279738 File Offset: 0x00277938
	// (set) Token: 0x06005CBA RID: 23738 RVA: 0x00279740 File Offset: 0x00277940
	public int Delay
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x06005CBB RID: 23739 RVA: 0x0027974C File Offset: 0x0027794C
	public e68()
	{
	}

	// Token: 0x06005CBC RID: 23740 RVA: 0x00279764 File Offset: 0x00277964
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		a0l.a(A_0 as c5x, this.a, this.b, null);
	}

	// Token: 0x040024FF RID: 9471
	private new c2w a = new c2w();

	// Token: 0x04002500 RID: 9472
	private int b;
}
