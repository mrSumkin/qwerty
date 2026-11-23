using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001B4F RID: 6991
[eiz("RV0")]
[Serializable]
public sealed class ejj : c3e, re
{
	// Token: 0x06009741 RID: 38721 RVA: 0x003B03D8 File Offset: 0x003AE5D8
	private ejj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("RV0:C");
		this.b = A_0.GetInt32("RV0:H");
	}

	// Token: 0x06009742 RID: 38722 RVA: 0x003B0404 File Offset: 0x003AE604
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("RV0:C", this.a);
		info.AddValue("RV0:H", this.b);
	}

	// Token: 0x06009743 RID: 38723 RVA: 0x003B0430 File Offset: 0x003AE630
	public ejj()
	{
	}

	// Token: 0x06009744 RID: 38724 RVA: 0x003B043C File Offset: 0x003AE63C
	public List<wq> as4(cgk A_0)
	{
		A_0.fu().c(new int?((int)Math.Max((double)A_0.MaxBattery, this.a * 10.0)));
		A_0.fu().i(false);
		return new List<wq>
		{
			new cq(this.b, this.a)
		};
	}

	// Token: 0x06009745 RID: 38725 RVA: 0x003B04A0 File Offset: 0x003AE6A0
	public override c3e xr()
	{
		ejj ejj = new ejj();
		this.ael(ejj);
		return ejj;
	}

	// Token: 0x06009746 RID: 38726 RVA: 0x003B04BC File Offset: 0x003AE6BC
	public override c3e xs(int A_0)
	{
		return new ejj
		{
			b = 15 + A_0 / 4,
			a = Math.Round(3.0 + (double)A_0 / 30.0, 1)
		};
	}

	// Token: 0x06009747 RID: 38727 RVA: 0x003B04F4 File Offset: 0x003AE6F4
	public override string xq()
	{
		return "";
	}

	// Token: 0x06009748 RID: 38728 RVA: 0x003B04FC File Offset: 0x003AE6FC
	protected override void ael(c3e A_0)
	{
		base.ael(A_0);
		ejj ejj = (ejj)A_0;
		ejj.a = this.a;
		ejj.b = this.b;
	}

	// Token: 0x04003A1E RID: 14878
	private double a;

	// Token: 0x04003A1F RID: 14879
	private int b;
}
