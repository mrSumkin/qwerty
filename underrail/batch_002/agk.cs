using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200106E RID: 4206
[eiz("THOOIJ")]
[Serializable]
public sealed class agk : cze
{
	// Token: 0x06005790 RID: 22416 RVA: 0x0026308C File Offset: 0x0026128C
	private agk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("THOOIJ:C");
		this.b = (A_0.GetValue("THOOIJ:T", typeof(edx)) as edx);
	}

	// Token: 0x06005791 RID: 22417 RVA: 0x002630D4 File Offset: 0x002612D4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("THOOIJ:C", this.a);
		info.AddValue("THOOIJ:T", this.b);
	}

	// Token: 0x06005792 RID: 22418 RVA: 0x00263100 File Offset: 0x00261300
	public agk(string A_0, ak1 A_1)
	{
		this.a = A_0;
		this.b = new edx(A_1);
	}

	// Token: 0x06005793 RID: 22419 RVA: 0x00263120 File Offset: 0x00261320
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.a) && this.b != null && this.b.ao() != null)
		{
			lh lh = ckw.a(this.a);
			if (lh != null)
			{
				lh.q5(this.b.ao(), A_0 as c5x);
			}
		}
	}

	// Token: 0x0400236B RID: 9067
	private new string a;

	// Token: 0x0400236C RID: 9068
	private edx b;
}
