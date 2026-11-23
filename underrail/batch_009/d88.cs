using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x0200129B RID: 4763
[eiz("POMEDEA")]
[Serializable]
public sealed class d88 : Aspect<c5x>, ISerializable, c98
{
	// Token: 0x0600680A RID: 26634 RVA: 0x002C059C File Offset: 0x002BE79C
	private d88(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("POMEDEA:C");
		this.b = (A_0.GetValue("POMEDEA:D", typeof(double?)) as double?);
	}

	// Token: 0x0600680B RID: 26635 RVA: 0x002C05E8 File Offset: 0x002BE7E8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("POMEDEA:C", this.a);
		info.AddValue("POMEDEA:D", this.b);
	}

	// Token: 0x0600680C RID: 26636 RVA: 0x002C061C File Offset: 0x002BE81C
	public string b()
	{
		return this.a;
	}

	// Token: 0x0600680D RID: 26637 RVA: 0x002C0624 File Offset: 0x002BE824
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600680E RID: 26638 RVA: 0x002C0630 File Offset: 0x002BE830
	public double? a()
	{
		return this.b;
	}

	// Token: 0x0600680F RID: 26639 RVA: 0x002C0638 File Offset: 0x002BE838
	public void a(double? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006810 RID: 26640 RVA: 0x002C0644 File Offset: 0x002BE844
	public d88(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006811 RID: 26641 RVA: 0x002C0650 File Offset: 0x002BE850
	public void r7(eds A_0)
	{
		if (!this.c && base.a8() != null && base.a8().j == cgy.b && base.a8().Area != null && base.a8().c(dm9.b))
		{
			bool flag = false;
			if (this.b != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area != null && serviceOrThrow.aqu().v().b().Area == base.a8().Area && aw1.b(serviceOrThrow.aqu().v().b(), base.a8()) <= this.b.Value)
				{
					flag = true;
				}
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				bpo.GetServiceOrThrow<e5f>().ash(this.a, null);
				this.c = true;
			}
		}
	}

	// Token: 0x04002AFE RID: 11006
	private string a;

	// Token: 0x04002AFF RID: 11007
	private double? b;

	// Token: 0x04002B00 RID: 11008
	[NonSerialized]
	private bool c;
}
