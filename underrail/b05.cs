using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001857 RID: 6231
[eiz("EMA")]
[Serializable]
public sealed class b05 : b1z, ISerializable
{
	// Token: 0x060084E6 RID: 34022 RVA: 0x00373ECC File Offset: 0x003720CC
	private b05(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ar7)A_0.GetValue("EMA:ER", typeof(ar7));
			return;
		}
		if (base.GetType() == typeof(b05))
		{
			this.a = (ar7)A_0.GetValue("_EntityRef", typeof(ar7));
			return;
		}
		this.a = (ar7)A_0.GetValue("EntityMaintenanceAction+_EntityRef", typeof(ar7));
	}

	// Token: 0x060084E7 RID: 34023 RVA: 0x00373F68 File Offset: 0x00372168
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("EMA:ER", this.a);
	}

	// Token: 0x060084E8 RID: 34024 RVA: 0x00373F84 File Offset: 0x00372184
	private b0b a()
	{
		return this.a.ao();
	}

	// Token: 0x060084E9 RID: 34025 RVA: 0x00373F94 File Offset: 0x00372194
	public b05(b0b A_0)
	{
		czh.a(A_0, "entity");
		this.a = new ar7(A_0);
	}

	// Token: 0x060084EA RID: 34026 RVA: 0x00373FB8 File Offset: 0x003721B8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a() != null && this.a().Area != null)
		{
			eds eds = new eds(A_0, A_1);
			eds.c = dz6.e();
			foreach (c98 c in Enumerable.ToList<c98>(Enumerable.OfType<c98>(this.a().Aspects)))
			{
				c.r7(eds);
			}
			if (!dz6.e())
			{
				HashSet<bqt> hashSet = new HashSet<bqt>();
				foreach (ak1 ak in this.a().l)
				{
					foreach (bqt bqt in ak.TriggerProxies)
					{
						hashSet.Add(bqt);
					}
				}
				foreach (bqt bqt2 in hashSet)
				{
					bqt2.b(this.a());
				}
			}
		}
		return dc4.b;
	}

	// Token: 0x040032F3 RID: 13043
	private new ar7 a;
}
