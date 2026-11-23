using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000114 RID: 276
[eiz("PCA")]
[Serializable]
public class dmv : di6, ISerializable
{
	// Token: 0x060006A6 RID: 1702 RVA: 0x0001C318 File Offset: 0x0001A518
	protected dmv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			di7.ReadList<btm>("PCA:RA", ref this.a, A_0);
			return;
		}
		if (base.GetType() == typeof(dmv))
		{
			this.a = (List<btm>)A_0.GetValue("_RemainingActivities", typeof(List<btm>));
			return;
		}
		this.a = (List<btm>)A_0.GetValue("ParallelCompositeActivity+_RemainingActivities", typeof(List<btm>));
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x0001C3B0 File Offset: 0x0001A5B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<btm>("PCA:RA", this.a, info);
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x0001C3CC File Offset: 0x0001A5CC
	public dmv() : base(new btm[0])
	{
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x0001C3E8 File Offset: 0x0001A5E8
	public dmv(params btm[] A_0) : base(A_0)
	{
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x0001C3FC File Offset: 0x0001A5FC
	public dmv(string A_0, params btm[] A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x0001C414 File Offset: 0x0001A614
	protected override bool b4(e6d A_0)
	{
		base.b4(A_0);
		bool result = true;
		for (int i = 0; i < base.f().Count; i++)
		{
			btm btm = base.f()[i];
			if (btm.d(A_0) != cdv.b)
			{
				result = false;
				if (btm.IsAsync)
				{
					base.b(btm);
				}
				else
				{
					this.a.Add(btm);
				}
			}
			else
			{
				base.a(btm);
			}
		}
		return result;
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x0001C490 File Offset: 0x0001A690
	protected override bool aen(e6d A_0)
	{
		bool flag = true;
		for (int i = 0; i < this.a.Count; i++)
		{
			btm btm = this.a[i];
			if (!btm.IsAsync && btm.f(A_0) != cdv.a)
			{
				base.a(btm);
				this.a.RemoveAt(i);
				i--;
			}
			else
			{
				flag = false;
			}
		}
		return base.aen(A_0) && flag;
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x0001C504 File Offset: 0x0001A704
	protected override void aep(e6d A_0)
	{
		base.aep(A_0);
		foreach (btm btm in this.a)
		{
			btm.g(A_0);
		}
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x0001C564 File Offset: 0x0001A764
	protected override void aeq(e6d A_0)
	{
		base.aeq(A_0);
		foreach (btm btm in this.a)
		{
			btm.e(A_0);
		}
	}

	// Token: 0x04000529 RID: 1321
	private new List<btm> a = new List<btm>();
}
