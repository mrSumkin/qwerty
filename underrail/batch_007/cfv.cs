using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001211 RID: 4625
[eiz("A9")]
[Serializable]
public sealed class cfv : cca, ISerializable
{
	// Token: 0x0600635E RID: 25438 RVA: 0x002AE084 File Offset: 0x002AC284
	private cfv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<string>("A9:D", ref this.b, A_0);
		this.a = A_0.GetString("A9:A");
	}

	// Token: 0x0600635F RID: 25439 RVA: 0x002AE0BC File Offset: 0x002AC2BC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("A9:A", this.a);
		di7.WriteList<string>("A9:D", this.b, info);
	}

	// Token: 0x06006360 RID: 25440 RVA: 0x002AE0E8 File Offset: 0x002AC2E8
	public List<string> b()
	{
		return this.b;
	}

	// Token: 0x06006361 RID: 25441 RVA: 0x002AE0F0 File Offset: 0x002AC2F0
	public void a(List<string> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006362 RID: 25442 RVA: 0x002AE0FC File Offset: 0x002AC2FC
	public string a()
	{
		return this.a;
	}

	// Token: 0x06006363 RID: 25443 RVA: 0x002AE104 File Offset: 0x002AC304
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006364 RID: 25444 RVA: 0x002AE110 File Offset: 0x002AC310
	protected override void adf(c5x A_0)
	{
		if (A_0 != null && A_0.Zone != null)
		{
			qy qy = new qy();
			qy.ad().Add(new bm3(50));
			qy.ad().Add(new eo4(this.a, this.b, new ar7(A_0)));
			A_0.Zone.ActionManager.g9(qy, atp.a);
		}
	}

	// Token: 0x06006365 RID: 25445 RVA: 0x002AE17C File Offset: 0x002AC37C
	public cfv()
	{
	}

	// Token: 0x040029DA RID: 10714
	private string a;

	// Token: 0x040029DB RID: 10715
	private List<string> b = new List<string>();
}
