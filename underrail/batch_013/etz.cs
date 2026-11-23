using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001287 RID: 4743
[a(typeof(cd0))]
[eiz("SAEA")]
[Serializable]
public class etz : cd0, ISerializable, dqh
{
	// Token: 0x06006713 RID: 26387 RVA: 0x002BC15C File Offset: 0x002BA35C
	protected etz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.b = A_0.GetInt32("SAEA:AS");
			this.c = A_0.GetInt32("SAEA:SC");
			this.d = A_0.GetInt32("SAEA:TS");
			this.e = A_0.GetInt32("SAEA:SD");
			if (ell.a() >= 242)
			{
				this.f = A_0.GetBoolean("SAEA:O");
			}
			if (ell.a() >= 308)
			{
				this.g = (A_0.GetValue("SAEA:C", typeof(int?)) as int?);
			}
			if (ell.a() >= 357)
			{
				this.h = (A_0.GetValue("SAEA:W", typeof(int?)) as int?);
				return;
			}
		}
		else
		{
			this.b = A_0.GetInt32("_AnimationStart");
			this.c = A_0.GetInt32("_StepChange");
			this.d = A_0.GetInt32("_TotalSteps");
			this.e = A_0.GetInt32("_StepDuration");
		}
	}

	// Token: 0x06006714 RID: 26388 RVA: 0x002BC2A4 File Offset: 0x002BA4A4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SAEA:AS", this.b);
		info.AddValue("SAEA:SC", this.c);
		info.AddValue("SAEA:TS", this.d);
		info.AddValue("SAEA:SD", this.e);
		info.AddValue("SAEA:O", this.f);
		info.AddValue("SAEA:C", this.g);
		info.AddValue("SAEA:W", this.h);
	}

	// Token: 0x06006715 RID: 26389 RVA: 0x002BC33C File Offset: 0x002BA53C
	public new int d()
	{
		return this.b;
	}

	// Token: 0x06006716 RID: 26390 RVA: 0x002BC344 File Offset: 0x002BA544
	public new void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006717 RID: 26391 RVA: 0x002BC350 File Offset: 0x002BA550
	public new int e()
	{
		return this.c;
	}

	// Token: 0x06006718 RID: 26392 RVA: 0x002BC358 File Offset: 0x002BA558
	public new void b(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006719 RID: 26393 RVA: 0x002BC364 File Offset: 0x002BA564
	public new int h()
	{
		return this.d;
	}

	// Token: 0x0600671A RID: 26394 RVA: 0x002BC36C File Offset: 0x002BA56C
	public new void c(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600671B RID: 26395 RVA: 0x002BC378 File Offset: 0x002BA578
	public new int g()
	{
		return this.e;
	}

	// Token: 0x0600671C RID: 26396 RVA: 0x002BC380 File Offset: 0x002BA580
	public new void d(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600671D RID: 26397 RVA: 0x002BC38C File Offset: 0x002BA58C
	public new bool a()
	{
		return this.f;
	}

	// Token: 0x0600671E RID: 26398 RVA: 0x002BC394 File Offset: 0x002BA594
	public new void a(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600671F RID: 26399 RVA: 0x002BC3A0 File Offset: 0x002BA5A0
	public new int? f()
	{
		return this.g;
	}

	// Token: 0x06006720 RID: 26400 RVA: 0x002BC3A8 File Offset: 0x002BA5A8
	public new void c(int? A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06006721 RID: 26401 RVA: 0x002BC3B4 File Offset: 0x002BA5B4
	public new int? i()
	{
		return this.h;
	}

	// Token: 0x06006722 RID: 26402 RVA: 0x002BC3BC File Offset: 0x002BA5BC
	public new void b(int? A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06006723 RID: 26403 RVA: 0x002BC3C8 File Offset: 0x002BA5C8
	public etz(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006724 RID: 26404 RVA: 0x002BC3E8 File Offset: 0x002BA5E8
	public override Point oc(bool A_0)
	{
		return this.a(A_0, null);
	}

	// Token: 0x06006725 RID: 26405 RVA: 0x002BC408 File Offset: 0x002BA608
	public new Point a(bool A_0, int? A_1 = null)
	{
		int num;
		if (A_0)
		{
			num = this.a(A_1);
		}
		else
		{
			num = this.a(new int?(0));
		}
		int num2 = this.b.Y;
		int x;
		if (this.h != null)
		{
			int num3 = num / this.h.Value;
			num2 += num3;
			x = num % this.h.Value;
		}
		else
		{
			x = num;
		}
		return new Point(x, num2);
	}

	// Token: 0x06006726 RID: 26406 RVA: 0x002BC480 File Offset: 0x002BA680
	public new int b()
	{
		return this.e * this.d;
	}

	// Token: 0x06006727 RID: 26407 RVA: 0x002BC490 File Offset: 0x002BA690
	public override void v2()
	{
		this.b = new Point(this.b.X, this.b.Y + 1);
	}

	// Token: 0x06006728 RID: 26408 RVA: 0x002BC4B8 File Offset: 0x002BA6B8
	public override void v3()
	{
		if (this.b.Y > 0)
		{
			this.b = new Point(this.b.X, this.b.Y - 1);
		}
	}

	// Token: 0x06006729 RID: 26409 RVA: 0x002BC4F0 File Offset: 0x002BA6F0
	public override void qa()
	{
		this.b = new Point(this.b.X, 0);
	}

	// Token: 0x0600672A RID: 26410 RVA: 0x002BC50C File Offset: 0x002BA70C
	public void aip()
	{
		if (this.f && this.g != null && base.a8() != null)
		{
			Random random = new Random(base.a8().GetHashCode());
			this.g = new int?(random.Next(this.d * this.e));
		}
	}

	// Token: 0x0600672B RID: 26411 RVA: 0x002BC570 File Offset: 0x002BA770
	private new int a(int? A_0 = null)
	{
		if (base.a8() == null || base.a8().Zone == null)
		{
			return 0;
		}
		if (this.d <= 0)
		{
			return this.b;
		}
		int num = this.b();
		if (this.i == null)
		{
			if (this.g != null)
			{
				this.i = this.g;
			}
			else
			{
				this.i = new int?(cuo.a.Next(this.d * this.e));
			}
		}
		int num2 = (A_0 != null) ? A_0.Value : ((int)base.a8().Zone.ElapsedZoneTime.TotalMilliseconds);
		if (this.f)
		{
			num2 += this.i.Value;
		}
		int num3 = num2 % num;
		return this.b + num3 / this.e * this.c;
	}

	// Token: 0x04002AAD RID: 10925
	private new static Random a = new Random();

	// Token: 0x04002AAE RID: 10926
	private new int b;

	// Token: 0x04002AAF RID: 10927
	private new int c = 1;

	// Token: 0x04002AB0 RID: 10928
	private new int d = 3;

	// Token: 0x04002AB1 RID: 10929
	private new int e = 100;

	// Token: 0x04002AB2 RID: 10930
	private new bool f;

	// Token: 0x04002AB3 RID: 10931
	private new int? g;

	// Token: 0x04002AB4 RID: 10932
	private new int? h;

	// Token: 0x04002AB5 RID: 10933
	[NonSerialized]
	private new int? i;
}
