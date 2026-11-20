using System;
using System.Runtime.Serialization;

// Token: 0x02001297 RID: 4759
[eiz("HREA44")]
[a(typeof(d8r))]
[Serializable]
public sealed class eno : d8r, ISerializable
{
	// Token: 0x060067F6 RID: 26614 RVA: 0x002C0260 File Offset: 0x002BE460
	private eno(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("HMREA:B");
	}

	// Token: 0x060067F7 RID: 26615 RVA: 0x002C027C File Offset: 0x002BE47C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("HMREA:B", this.a);
	}

	// Token: 0x060067F8 RID: 26616 RVA: 0x002C0298 File Offset: 0x002BE498
	public eno(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060067F9 RID: 26617 RVA: 0x002C02A4 File Offset: 0x002BE4A4
	public override void tt(int A_0, bool A_1)
	{
		if (!this.a && base.a8().o.b != null)
		{
			this.a = true;
			cd0 b = base.a8().o.b;
			b.a += "_Withered";
		}
	}

	// Token: 0x04002AF9 RID: 11001
	private bool a;
}
