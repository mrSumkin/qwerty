using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AAA RID: 2730
[eiz("EMGJ")]
[Serializable]
public sealed class ez3 : cze
{
	// Token: 0x06003FDC RID: 16348 RVA: 0x001839F4 File Offset: 0x00181BF4
	private ez3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003FDD RID: 16349 RVA: 0x00183A00 File Offset: 0x00181C00
	public ez3()
	{
	}

	// Token: 0x06003FDE RID: 16350 RVA: 0x00183A08 File Offset: 0x00181C08
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			bxc aspect = c5x.GetAspect<bxc>();
			if (aspect != null && !aspect.i())
			{
				if (c5x.s.b == null && c5x.Zone != null)
				{
					c5x.Zone.ActionManager.g9(new ez3.a(c5x), atp.a);
				}
				c5x.TileFormationModifiers.s3(1);
				c5x.z();
			}
		}
	}

	// Token: 0x02000AAB RID: 2731
	[eiz("EMMUA")]
	[Serializable]
	private new sealed class a : b1z
	{
		// Token: 0x06003FDF RID: 16351 RVA: 0x00183A80 File Offset: 0x00181C80
		private a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
		{
			this.a = (A_0.GetValue("EMMUA:T", typeof(ar7)) as ar7);
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x00183AAC File Offset: 0x00181CAC
		public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			base.GetObjectData(info, ctx);
			info.AddValue("EMMUA:T", this.a);
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x00183AC8 File Offset: 0x00181CC8
		public a(b0b A_0)
		{
			this.a = new ar7(A_0);
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x00183AE0 File Offset: 0x00181CE0
		protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
		{
			if (this.a == null)
			{
				return dc4.e;
			}
			c5x c5x = this.a.ao() as c5x;
			if (c5x == null)
			{
				return dc4.e;
			}
			if (c5x.s.b == null)
			{
				bim bim = new bim(c5x);
				bim.d(new List<cze>
				{
					new aqc()
				});
				c5x.SetAspect<bim>(bim);
			}
			return dc4.c;
		}

		// Token: 0x04001BE4 RID: 7140
		private new ar7 a;
	}
}
