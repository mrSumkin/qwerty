using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020016CA RID: 5834
[eiz("DSMA")]
[Serializable]
public sealed class egp : a6k
{
	// Token: 0x06007F16 RID: 32534 RVA: 0x0035C62C File Offset: 0x0035A82C
	private egp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F17 RID: 32535 RVA: 0x0035C638 File Offset: 0x0035A838
	public egp()
	{
	}

	// Token: 0x06007F18 RID: 32536 RVA: 0x0035C644 File Offset: 0x0035A844
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() != null && base.vg().q().Zone != null && base.vg().q().h.b != null && base.vg().q().i.b != null)
		{
			ak1 ak = base.vg().h() as ak1;
			if (ak != null && !aw1.a(null, ak, false, null))
			{
				awx awx = new awx();
				awx.a(m7.b);
				awx.a(false);
				awx.ad().Add(new a4s(new egp.a(ak), new ar7(base.vg().q()), null, null));
				base.vg().q().i.b.a(awx, atp.a, true, false);
				return dc4.c;
			}
			bmj.a(base.vg().q(), new d53("Недостаточно места", adi.l, null, false));
			a7v.a(new h0("Недостаточно места, чтобы выйти здесь.", new Color?(adi.l)));
		}
		return dc4.e;
	}

	// Token: 0x020016CB RID: 5835
	[eiz("DSMAa")]
	[Serializable]
	private new sealed class a : cze
	{
		// Token: 0x06007F19 RID: 32537 RVA: 0x0035C768 File Offset: 0x0035A968
		private a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
		{
			this.a = (A_0.GetValue("DSMAa:T", typeof(edx)) as edx);
		}

		// Token: 0x06007F1A RID: 32538 RVA: 0x0035C794 File Offset: 0x0035A994
		public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			base.GetObjectData(info, ctx);
			info.AddValue("DSMAa:T", this.a);
		}

		// Token: 0x06007F1B RID: 32539 RVA: 0x0035C7B0 File Offset: 0x0035A9B0
		public a(ak1 A_0)
		{
			this.a = new edx(A_0);
		}

		// Token: 0x06007F1C RID: 32540 RVA: 0x0035C7C8 File Offset: 0x0035A9C8
		public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
		{
			bool serviceOrThrow = bpo.GetServiceOrThrow<cnk>() != null;
			c5x c5x = A_0 as c5x;
			if (serviceOrThrow && c5x != null && this.a != null && this.a.ao() != null && c5x != null && c5x.h.b != null && c5x.h.b.aa().Vehicle != null)
			{
				if (!aw1.a(null, this.a.ao(), false, null))
				{
					new an9().ym(c5x, null, null);
					c5x.Location = this.a.ao().Location.a();
					c5x.ah();
					return;
				}
				bmj.a(A_0, new d53("Недостаточно места", adi.l, null, false));
				a7v.a(new h0("Недостаточно места, чтобы выйти здесь.", new Color?(adi.l)));
			}
		}

		// Token: 0x04003230 RID: 12848
		private new edx a;
	}
}
