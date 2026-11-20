using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001A65 RID: 6757
[eiz("DPPAM")]
[Serializable]
public sealed class emg : bns, ISerializable
{
	// Token: 0x060092B7 RID: 37559 RVA: 0x0039FF50 File Offset: 0x0039E150
	private emg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060092B8 RID: 37560 RVA: 0x0039FF5C File Offset: 0x0039E15C
	public emg()
	{
	}

	// Token: 0x060092B9 RID: 37561 RVA: 0x0039FF64 File Offset: 0x0039E164
	public override void ate(cmn A_0, cd1 A_1, efk A_2, efk A_3, double A_4, double A_5, bool A_6, AmmoType A_7, bool A_8)
	{
		this.atf(A_0, A_1, A_2, A_3);
	}

	// Token: 0x060092BA RID: 37562 RVA: 0x0039FF74 File Offset: 0x0039E174
	public override void atf(cmn A_0, cd1 A_1, efk A_2, efk A_3)
	{
		double num = euf.d(Convert.ToInt32(qw.a(A_3.Level)), A_3) * 0.5;
		A_0.g *= 1.0 - num;
	}

	// Token: 0x060092BB RID: 37563 RVA: 0x0039FFBC File Offset: 0x0039E1BC
	public override string h0(cd1 A_0)
	{
		return "Урон уменьшен решимостью цели.";
	}

	// Token: 0x060092BC RID: 37564 RVA: 0x0039FFC4 File Offset: 0x0039E1C4
	public override bns h1()
	{
		emg emg = new emg();
		this.h2(emg);
		return emg;
	}
}
