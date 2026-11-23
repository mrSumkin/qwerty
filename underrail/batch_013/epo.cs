using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using Ouroboros.Core.Logging;

// Token: 0x02000F6B RID: 3947
[eiz("PEA3")]
[Serializable]
public abstract class epo : Aspect<c5x>, bp1, d5q
{
	// Token: 0x06005009 RID: 20489 RVA: 0x0023E89C File Offset: 0x0023CA9C
	protected epo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = A_0.GetBoolean("PEA3:E");
	}

	// Token: 0x0600500A RID: 20490 RVA: 0x0023E8C0 File Offset: 0x0023CAC0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PEA3:E", this.c);
	}

	// Token: 0x0600500B RID: 20491 RVA: 0x0023E8DC File Offset: 0x0023CADC
	public bool d()
	{
		return this.c;
	}

	// Token: 0x0600500C RID: 20492 RVA: 0x0023E8E4 File Offset: 0x0023CAE4
	public void b(bool A_0)
	{
		if (this.c != A_0)
		{
			this.c = A_0;
			if (this.b)
			{
				if (!this.c)
				{
					this.a();
					return;
				}
				this.b();
			}
		}
	}

	// Token: 0x0600500D RID: 20493 RVA: 0x0023E91C File Offset: 0x0023CB1C
	protected epo(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x0600500E RID: 20494
	protected abstract List<d0z> kd();

	// Token: 0x0600500F RID: 20495 RVA: 0x0023E92C File Offset: 0x0023CB2C
	protected virtual bool b(c5x A_0, abo A_1)
	{
		return true;
	}

	// Token: 0x06005010 RID: 20496 RVA: 0x0023E930 File Offset: 0x0023CB30
	protected virtual bool c(c5x A_0, abo A_1)
	{
		return true;
	}

	// Token: 0x06005011 RID: 20497 RVA: 0x0023E934 File Offset: 0x0023CB34
	public void mx()
	{
		this.b();
		this.b = true;
	}

	// Token: 0x06005012 RID: 20498 RVA: 0x0023E944 File Offset: 0x0023CB44
	public void my()
	{
		this.a();
		this.b = false;
	}

	// Token: 0x06005013 RID: 20499 RVA: 0x0023E954 File Offset: 0x0023CB54
	public virtual bool kc(c5x A_0, abo A_1)
	{
		return true;
	}

	// Token: 0x06005014 RID: 20500 RVA: 0x0023E958 File Offset: 0x0023CB58
	public bool afu(c5x A_0, abo A_1)
	{
		return A_0 != null && this.b(A_0, A_1) && this.a(A_0, A_1) && this.c(A_0, A_1);
	}

	// Token: 0x06005015 RID: 20501 RVA: 0x0023E988 File Offset: 0x0023CB88
	private void b()
	{
		if (!this.a && base.a8() != null && base.a8().Zone != null)
		{
			d5s addon = base.a8().Zone.GetAddon<d5s>();
			if (addon != null)
			{
				List<d0z> list = this.kd();
				if (list != null)
				{
					foreach (d0z a_ in list)
					{
						addon.aj1(a_, this);
					}
				}
				this.a = true;
			}
		}
	}

	// Token: 0x06005016 RID: 20502 RVA: 0x0023EA30 File Offset: 0x0023CC30
	private void a()
	{
		if (this.a && base.a8() != null && base.a8().Zone != null)
		{
			d5s addon = base.a8().Zone.GetAddon<d5s>();
			if (addon != null)
			{
				List<d0z> list = this.kd();
				if (list != null)
				{
					foreach (d0z a_ in list)
					{
						addon.aj2(a_);
					}
				}
				this.a = false;
			}
		}
	}

	// Token: 0x06005017 RID: 20503 RVA: 0x0023EAD8 File Offset: 0x0023CCD8
	private bool a(c5x A_0, abo A_1)
	{
		try
		{
			abo abo = A_1.a();
			aud aud = A_0.Zone.b(abo.c.b);
			if (aud == null)
			{
				if (A_0.Area == null)
				{
					return false;
				}
				aud = A_0.Area;
			}
			a0l.a(A_0, aud, abo.c.a.a() / 4f, null, true);
			return true;
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Ошибка при использовании портала.", new object[0]);
		}
		return false;
	}

	// Token: 0x040020A7 RID: 8359
	[NonSerialized]
	private bool a;

	// Token: 0x040020A8 RID: 8360
	[NonSerialized]
	private bool b;

	// Token: 0x040020A9 RID: 8361
	private bool c = true;
}
