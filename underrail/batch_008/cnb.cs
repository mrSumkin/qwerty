using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001318 RID: 4888
[a(typeof(bim))]
[eiz("DEA")]
[Serializable]
public class cnb : b0e
{
	// Token: 0x06006DFC RID: 28156 RVA: 0x002DFD94 File Offset: 0x002DDF94
	protected cnb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (bjp)A_0.GetValue("DEA:CTFM", typeof(bjp));
		if (ell.a() >= 44)
		{
			this.b = (A_0.GetValue("DEA:C", typeof(int?)) as int?);
			this.c = (A_0.GetValue("DEA:O", typeof(int?)) as int?);
		}
		if (ell.a() >= 71)
		{
			this.e = (A_0.GetValue("DEA:L", typeof(Guid?)) as Guid?);
		}
		if (ell.a() >= 354)
		{
			this.f = A_0.GetBoolean("DEA:S");
			return;
		}
		this.f = true;
	}

	// Token: 0x06006DFD RID: 28157 RVA: 0x002DFE8C File Offset: 0x002DE08C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DEA:CTFM", this.a);
		info.AddValue("DEA:C", this.b);
		info.AddValue("DEA:O", this.c);
		info.AddValue("DEA:L", this.e);
		info.AddValue("DEA:S", this.f);
	}

	// Token: 0x06006DFE RID: 28158 RVA: 0x002DFF08 File Offset: 0x002DE108
	public bjp d()
	{
		return this.a;
	}

	// Token: 0x06006DFF RID: 28159 RVA: 0x002DFF10 File Offset: 0x002DE110
	public void a(bjp A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006E00 RID: 28160 RVA: 0x002DFF1C File Offset: 0x002DE11C
	public override d98 pr()
	{
		return d98.c;
	}

	// Token: 0x06006E01 RID: 28161 RVA: 0x002DFF20 File Offset: 0x002DE120
	public override void ps(d98 A_0)
	{
	}

	// Token: 0x06006E02 RID: 28162 RVA: 0x002DFF24 File Offset: 0x002DE124
	public override bool af1()
	{
		return true;
	}

	// Token: 0x06006E03 RID: 28163 RVA: 0x002DFF28 File Offset: 0x002DE128
	public override void af2(bool A_0)
	{
	}

	// Token: 0x06006E04 RID: 28164 RVA: 0x002DFF2C File Offset: 0x002DE12C
	public Guid? b()
	{
		return this.e;
	}

	// Token: 0x06006E05 RID: 28165 RVA: 0x002DFF34 File Offset: 0x002DE134
	public void a(Guid? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006E06 RID: 28166 RVA: 0x002DFF40 File Offset: 0x002DE140
	public bool e()
	{
		return this.f;
	}

	// Token: 0x06006E07 RID: 28167 RVA: 0x002DFF48 File Offset: 0x002DE148
	public void a(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006E08 RID: 28168 RVA: 0x002DFF54 File Offset: 0x002DE154
	public cnb(c5x A_0) : base(A_0)
	{
		base.j(true);
	}

	// Token: 0x06006E09 RID: 28169 RVA: 0x002DFF78 File Offset: 0x002DE178
	public override void mx()
	{
		base.mx();
		this.a();
	}

	// Token: 0x06006E0A RID: 28170 RVA: 0x002DFF88 File Offset: 0x002DE188
	public override avd[] jz()
	{
		if (!base.q() && this.d().b(4194304L))
		{
			return new avd[]
			{
				new avd("open", "Abilities.71", "Открыть", "Попробовать открыть дверь."),
				new avd("look", "Abilities.80", "Посмотреть", "Слегка и тихо открыть дверь и заглянуть за неё.")
			};
		}
		return null;
	}

	// Token: 0x06006E0B RID: 28171 RVA: 0x002DFFF8 File Offset: 0x002DE1F8
	protected override void mz(c5x A_0, string A_1 = null)
	{
		if (A_1 == "look")
		{
			if (A_0 != null && !base.q() && this.d().b(4194304L))
			{
				adv.a(A_0, base.a8(), false);
				return;
			}
		}
		else
		{
			this.a(A_0, false);
		}
	}

	// Token: 0x06006E0C RID: 28172 RVA: 0x002E0054 File Offset: 0x002DE254
	protected override void af3(bool A_0)
	{
		base.af3(A_0);
		bjp bjp = new bjp();
		if (!A_0)
		{
			if (this.d() != null)
			{
				bjp = new bjp(this.d().b);
			}
			else
			{
				bjp = new bjp(new List<byte>
				{
					0
				});
			}
		}
		bjp.s3(9);
		base.a8().TileFormationModifiers = bjp;
		this.a();
	}

	// Token: 0x06006E0D RID: 28173 RVA: 0x002E00C4 File Offset: 0x002DE2C4
	protected override void af4(c5x A_0)
	{
		base.af4(A_0);
		this.a();
	}

	// Token: 0x06006E0E RID: 28174 RVA: 0x002E00D4 File Offset: 0x002DE2D4
	protected override void af5(c5x A_0)
	{
		base.af5(A_0);
		this.a();
	}

	// Token: 0x06006E0F RID: 28175 RVA: 0x002E00E4 File Offset: 0x002DE2E4
	protected override bool ww(c5x A_0, out string A_1)
	{
		if (!base.ww(A_0, out A_1))
		{
			return false;
		}
		if (base.q())
		{
			foreach (ak1 a_ in base.a8().l)
			{
				if (aw1.a(null, a_, false, null))
				{
					A_1 = "Заблокировано";
					return false;
				}
			}
			return true;
		}
		return true;
	}

	// Token: 0x06006E10 RID: 28176 RVA: 0x002E0174 File Offset: 0x002DE374
	private void a(c5x A_0, bool A_1)
	{
		base.mz(A_0, null);
		if (!A_1)
		{
			this.a(A_0);
		}
	}

	// Token: 0x06006E11 RID: 28177 RVA: 0x002E018C File Offset: 0x002DE38C
	private void a(c5x A_0)
	{
		if (this.e != null)
		{
			if (this.d == null)
			{
				this.d = new EntityAspectReference<cnb, bim>(base.a8().Area, this.e.Value);
			}
			if (this.d.ao() != null && base.q() != this.d.ao().q())
			{
				string text;
				if (this.d.ao().ww(A_0, out text))
				{
					this.d.ao().a(A_0, true);
				}
				if (A_0.IsPlayer && !string.IsNullOrEmpty(text))
				{
					bmj.a(this.d.ao().a8(), new d53(text, adi.l, null, true));
				}
			}
		}
	}

	// Token: 0x06006E12 RID: 28178 RVA: 0x002E0264 File Offset: 0x002DE464
	private void a()
	{
		if (base.q())
		{
			if (this.c != null && base.a8().VisualPriority != this.c.Value)
			{
				base.a8().VisualPriority = this.c.Value;
				base.a8().ah();
				return;
			}
		}
		else if (this.b != null && base.a8().VisualPriority != this.b.Value)
		{
			base.a8().VisualPriority = this.b.Value;
			base.a8().ah();
		}
	}

	// Token: 0x04002CFF RID: 11519
	private new bjp a = new bjp();

	// Token: 0x04002D00 RID: 11520
	public new int? b;

	// Token: 0x04002D01 RID: 11521
	public int? c;

	// Token: 0x04002D02 RID: 11522
	[NonSerialized]
	private EntityAspectReference<cnb, bim> d;

	// Token: 0x04002D03 RID: 11523
	private Guid? e;

	// Token: 0x04002D04 RID: 11524
	private bool f = true;
}
