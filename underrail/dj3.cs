using System;
using System.Runtime.Serialization;

// Token: 0x0200190D RID: 6413
[eiz("NEI")]
[elw(typeof(d48))]
[Serializable]
public class dj3 : bk3, ISerializable
{
	// Token: 0x06008824 RID: 34852 RVA: 0x00386404 File Offset: 0x00384604
	protected dj3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetBoolean("NEI:CR");
			return;
		}
		if (base.GetType() == typeof(dj3))
		{
			this.a = A_0.GetBoolean("_CombatReady");
			return;
		}
		this.a = A_0.GetBoolean("NonEquippableItem+_CombatReady");
	}

	// Token: 0x06008825 RID: 34853 RVA: 0x00386474 File Offset: 0x00384674
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("NEI:CR", this.a);
	}

	// Token: 0x06008826 RID: 34854 RVA: 0x00386490 File Offset: 0x00384690
	public bool m()
	{
		return this.a;
	}

	// Token: 0x06008827 RID: 34855 RVA: 0x00386498 File Offset: 0x00384698
	public void b(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008828 RID: 34856 RVA: 0x003864A4 File Offset: 0x003846A4
	public override bk3 tw()
	{
		dj3 dj = new dj3();
		this.ai7(dj);
		return dj;
	}

	// Token: 0x06008829 RID: 34857 RVA: 0x003864C0 File Offset: 0x003846C0
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		((dj3)A_0).a = this.a;
	}

	// Token: 0x0600882A RID: 34858 RVA: 0x003864DC File Offset: 0x003846DC
	public dj3()
	{
	}

	// Token: 0x0400366B RID: 13931
	private new bool a;
}
