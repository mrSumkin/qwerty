using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020013DC RID: 5084
[eiz("CEA2")]
[Serializable]
public sealed class e3t : dvv, ISerializable
{
	// Token: 0x06007282 RID: 29314 RVA: 0x00301D20 File Offset: 0x002FFF20
	private e3t(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (EntityAspectReference<dha, dha>)A_0.GetValue("CEA2:ER", typeof(EntityAspectReference<dha, dha>));
			return;
		}
		if (base.GetType() == typeof(e3t))
		{
			this.a = (EntityAspectReference<dha, dha>)A_0.GetValue("_EffectRef", typeof(EntityAspectReference<dha, dha>));
			return;
		}
		this.a = (EntityAspectReference<dha, dha>)A_0.GetValue("CycleEffectAction+_EffectRef", typeof(EntityAspectReference<dha, dha>));
	}

	// Token: 0x06007283 RID: 29315 RVA: 0x00301DBC File Offset: 0x002FFFBC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CEA2:ER", this.a);
	}

	// Token: 0x06007284 RID: 29316 RVA: 0x00301DD8 File Offset: 0x002FFFD8
	private dha a()
	{
		return this.a.ao();
	}

	// Token: 0x06007285 RID: 29317 RVA: 0x00301DE8 File Offset: 0x002FFFE8
	public e3t(dha A_0)
	{
		this.a = new EntityAspectReference<dha, dha>(A_0);
	}

	// Token: 0x06007286 RID: 29318 RVA: 0x00301DFC File Offset: 0x002FFFFC
	protected override dc4 dt()
	{
		if (this.a() == null)
		{
			return dc4.e;
		}
		return dc4.b;
	}

	// Token: 0x06007287 RID: 29319 RVA: 0x00301E10 File Offset: 0x00300010
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a() == null || this.a().a8() == null || this.a().a8().j != cgy.b)
		{
			return dc4.c;
		}
		if (this.a().a(A_1.TotalMilliseconds))
		{
			if (this.a().a8() != null && this.a().a8().j == cgy.b)
			{
				this.a().a8().an();
			}
			return dc4.c;
		}
		return dc4.b;
	}

	// Token: 0x06007288 RID: 29320 RVA: 0x00301EA4 File Offset: 0x003000A4
	protected override void j4()
	{
		if (this.a() != null && this.a().a8() != null && this.a().a8().j == cgy.b)
		{
			this.a().a8().an();
		}
	}

	// Token: 0x04002EC7 RID: 11975
	private new EntityAspectReference<dha, dha> a;
}
