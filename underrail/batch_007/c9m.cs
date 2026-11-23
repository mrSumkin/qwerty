using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;
using Ouroboros.Playfield.References;

// Token: 0x0200133A RID: 4922
[eiz("SDA")]
[Serializable]
public sealed class c9m : dvv, ISerializable
{
	// Token: 0x06006F88 RID: 28552 RVA: 0x002ECE88 File Offset: 0x002EB088
	private c9m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (EntityAspectReference<j7, j7>)A_0.GetValue("SDA:IR", typeof(EntityAspectReference<j7, j7>));
			this.b = (EntityAspectReference<j7, j7>)A_0.GetValue("SDA:TR", typeof(EntityAspectReference<j7, j7>));
			this.c = A_0.GetBoolean("SDA:UOD");
			if (ell.a() >= 34)
			{
				this.d = A_0.GetString("SDA:CD");
				if (ell.a() >= 86)
				{
					this.e = A_0.GetBoolean("SDA:I");
					return;
				}
			}
		}
		else
		{
			if (base.GetType() == typeof(c9m))
			{
				this.a = (EntityAspectReference<j7, j7>)A_0.GetValue("_InitiatorRef", typeof(EntityAspectReference<j7, j7>));
				this.b = (EntityAspectReference<j7, j7>)A_0.GetValue("_TargetRef", typeof(EntityAspectReference<j7, j7>));
				this.c = A_0.GetBoolean("_UseOwnDialog");
				return;
			}
			this.a = (EntityAspectReference<j7, j7>)A_0.GetValue("StartDialogAction+_InitiatorRef", typeof(EntityAspectReference<j7, j7>));
			this.b = (EntityAspectReference<j7, j7>)A_0.GetValue("StartDialogAction+_TargetRef", typeof(EntityAspectReference<j7, j7>));
			this.c = A_0.GetBoolean("StartDialogAction+_UseOwnDialog");
		}
	}

	// Token: 0x06006F89 RID: 28553 RVA: 0x002ECFF0 File Offset: 0x002EB1F0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SDA:IR", this.a);
		info.AddValue("SDA:TR", this.b);
		info.AddValue("SDA:UOD", this.c);
		info.AddValue("SDA:CD", this.d);
		info.AddValue("SDA:I", this.e);
	}

	// Token: 0x06006F8A RID: 28554 RVA: 0x002ED05C File Offset: 0x002EB25C
	private j7 b()
	{
		return this.a.ao();
	}

	// Token: 0x06006F8B RID: 28555 RVA: 0x002ED06C File Offset: 0x002EB26C
	private j7 a()
	{
		return this.b.ao();
	}

	// Token: 0x06006F8C RID: 28556 RVA: 0x002ED07C File Offset: 0x002EB27C
	public string c()
	{
		return this.d;
	}

	// Token: 0x06006F8D RID: 28557 RVA: 0x002ED084 File Offset: 0x002EB284
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006F8E RID: 28558 RVA: 0x002ED090 File Offset: 0x002EB290
	public c9m(j7 A_0, j7 A_1, bool A_2, string A_3 = null, bool A_4 = false)
	{
		this.a = new EntityAspectReference<j7, j7>(A_0);
		this.b = new EntityAspectReference<j7, j7>(A_1);
		this.c = A_2;
		this.d = A_3;
		this.e = A_4;
	}

	// Token: 0x06006F8F RID: 28559 RVA: 0x002ED0C8 File Offset: 0x002EB2C8
	protected override dc4 dt()
	{
		if (this.b() == null)
		{
			dux.b(LogSeverity.Error, "Unable to initialize StartDialogAction. Initiator was null.", new object[0]);
			return dc4.e;
		}
		if (this.a() == null)
		{
			dux.b(LogSeverity.Error, "Unable to initialize StartDialogAction. Target was null.", new object[0]);
			return dc4.e;
		}
		if (this.a().h7() != null)
		{
			amc aspect = this.a().h7().GetAspect<amc>();
			if (aspect != null && aspect.aa().Dead)
			{
				dux.b(LogSeverity.Warning, "Попытка поговорить с трупом ({0}).", new object[]
				{
					this.a().e9()
				});
				return dc4.e;
			}
		}
		string text;
		if (!string.IsNullOrWhiteSpace(this.d))
		{
			text = this.d;
		}
		else if (this.c)
		{
			text = this.b().fd();
		}
		else
		{
			text = this.a().fd();
		}
		if (string.IsNullOrEmpty(text))
		{
			dux.b(LogSeverity.Error, "Unable to initialize StartDialogAction. Dialog model name was null.", new object[0]);
			return dc4.e;
		}
		if (this.b().a8() != null && this.a().a8() != null)
		{
			aw1.b(this.b().a8(), this.a().a8(), false);
		}
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			List<ble> list = new List<ble>();
			list.Add(this.b());
			list.Add(this.a());
			aud aud = null;
			aud aud2 = null;
			if (this.b().a8() != null)
			{
				aud = this.b().a8().Area;
			}
			if (this.a().a8() != null)
			{
				aud2 = this.a().a8().Area;
			}
			if (aud != null)
			{
				list.AddRange(a37.a(aud));
			}
			if (aud2 != null && aud2 != aud)
			{
				list.AddRange(a37.a(aud2));
			}
			bn5 bn;
			if (this.a() != null && !this.a().a8().IsPlayer)
			{
				bn = (this.a() as bn5);
			}
			else
			{
				bn = (this.b() as bn5);
			}
			bool a_ = bn != null && bn.e();
			if (service.amu(text, this.b().a8(), this.a().a8(), list, false, a_, bn != null && bn.b(), null, false, this.e))
			{
				return dc4.c;
			}
		}
		return dc4.e;
	}

	// Token: 0x06006F90 RID: 28560 RVA: 0x002ED348 File Offset: 0x002EB548
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		return dc4.e;
	}

	// Token: 0x04002D95 RID: 11669
	private new EntityAspectReference<j7, j7> a;

	// Token: 0x04002D96 RID: 11670
	private EntityAspectReference<j7, j7> b;

	// Token: 0x04002D97 RID: 11671
	private bool c;

	// Token: 0x04002D98 RID: 11672
	private string d;

	// Token: 0x04002D99 RID: 11673
	public bool e;
}
