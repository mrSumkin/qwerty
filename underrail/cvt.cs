using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001068 RID: 4200
[eiz("SCVAIINPJ")]
[Serializable]
public sealed class cvt : cze, ISerializable
{
	// Token: 0x06005747 RID: 22343 RVA: 0x0026237C File Offset: 0x0026057C
	private cvt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("SCVAIINPJ:I");
		this.b = A_0.GetString("SCVAIINPJ:IC");
		this.c = A_0.GetBoolean("SCVAIINPJ:E");
		this.i = A_0.GetInt32("SCVAIINPJ:FX");
		this.j = A_0.GetInt32("SCVAIINPJ:FY");
		this.d = (A_0.GetValue("SCVAIINPJ:IX", typeof(int?)) as int?);
		this.e = (A_0.GetValue("SCVAIINPJ:C", typeof(Color?)) as Color?);
		this.f = A_0.GetBoolean("SCVAIINPJ:SC");
		this.g = (A_0.GetValue("SCVAIINPJ:A", typeof(float?)) as float?);
		this.h = A_0.GetBoolean("SCVAIINPJ:SA");
		this.k = A_0.GetBoolean("SCVAIINPJ:SFX");
		this.l = A_0.GetBoolean("SCVAIINPJ:SFY");
	}

	// Token: 0x06005748 RID: 22344 RVA: 0x0026249C File Offset: 0x0026069C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SCVAIINPJ:I", this.a);
		info.AddValue("SCVAIINPJ:IC", this.b);
		info.AddValue("SCVAIINPJ:E", this.c);
		info.AddValue("SCVAIINPJ:IX", this.d);
		info.AddValue("SCVAIINPJ:C", this.e);
		info.AddValue("SCVAIINPJ:SC", this.f);
		info.AddValue("SCVAIINPJ:A", this.g);
		info.AddValue("SCVAIINPJ:SA", this.h);
		info.AddValue("SCVAIINPJ:FX", this.i);
		info.AddValue("SCVAIINPJ:SFX", this.k);
		info.AddValue("SCVAIINPJ:FY", this.j);
		info.AddValue("SCVAIINPJ:SFY", this.l);
	}

	// Token: 0x06005749 RID: 22345 RVA: 0x0026258C File Offset: 0x0026078C
	public bool g()
	{
		return this.a;
	}

	// Token: 0x0600574A RID: 22346 RVA: 0x00262594 File Offset: 0x00260794
	public void f(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600574B RID: 22347 RVA: 0x002625A0 File Offset: 0x002607A0
	public bool b()
	{
		return this.c;
	}

	// Token: 0x0600574C RID: 22348 RVA: 0x002625A8 File Offset: 0x002607A8
	public void d(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600574D RID: 22349 RVA: 0x002625B4 File Offset: 0x002607B4
	public string j()
	{
		return this.b;
	}

	// Token: 0x0600574E RID: 22350 RVA: 0x002625BC File Offset: 0x002607BC
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600574F RID: 22351 RVA: 0x002625C8 File Offset: 0x002607C8
	public int a()
	{
		return this.i;
	}

	// Token: 0x06005750 RID: 22352 RVA: 0x002625D0 File Offset: 0x002607D0
	public void b(int A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06005751 RID: 22353 RVA: 0x002625DC File Offset: 0x002607DC
	public int f()
	{
		return this.j;
	}

	// Token: 0x06005752 RID: 22354 RVA: 0x002625E4 File Offset: 0x002607E4
	public void a(int A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06005753 RID: 22355 RVA: 0x002625F0 File Offset: 0x002607F0
	public int? h()
	{
		return this.d;
	}

	// Token: 0x06005754 RID: 22356 RVA: 0x002625F8 File Offset: 0x002607F8
	public void a(int? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005755 RID: 22357 RVA: 0x00262604 File Offset: 0x00260804
	public Color? c()
	{
		return this.e;
	}

	// Token: 0x06005756 RID: 22358 RVA: 0x0026260C File Offset: 0x0026080C
	public void a(Color? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005757 RID: 22359 RVA: 0x00262618 File Offset: 0x00260818
	public bool l()
	{
		return this.f;
	}

	// Token: 0x06005758 RID: 22360 RVA: 0x00262620 File Offset: 0x00260820
	public void e(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005759 RID: 22361 RVA: 0x0026262C File Offset: 0x0026082C
	public float? d()
	{
		return this.g;
	}

	// Token: 0x0600575A RID: 22362 RVA: 0x00262634 File Offset: 0x00260834
	public void a(float? A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600575B RID: 22363 RVA: 0x00262640 File Offset: 0x00260840
	public bool e()
	{
		return this.h;
	}

	// Token: 0x0600575C RID: 22364 RVA: 0x00262648 File Offset: 0x00260848
	public void a(bool A_0)
	{
		this.h = A_0;
	}

	// Token: 0x0600575D RID: 22365 RVA: 0x00262654 File Offset: 0x00260854
	public bool i()
	{
		return this.k;
	}

	// Token: 0x0600575E RID: 22366 RVA: 0x0026265C File Offset: 0x0026085C
	public void b(bool A_0)
	{
		this.k = A_0;
	}

	// Token: 0x0600575F RID: 22367 RVA: 0x00262668 File Offset: 0x00260868
	public bool k()
	{
		return this.l;
	}

	// Token: 0x06005760 RID: 22368 RVA: 0x00262670 File Offset: 0x00260870
	public void c(bool A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06005761 RID: 22369 RVA: 0x0026267C File Offset: 0x0026087C
	public cvt()
	{
	}

	// Token: 0x06005762 RID: 22370 RVA: 0x00262684 File Offset: 0x00260884
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			c7j c7j = c5x.GetAspect<bim>() as c7j;
			if (c7j != null && (!Enumerable.Any<coh>(c7j.ItemContainer.z2(), new Func<coh, bool>(this.a)) ^ this.a))
			{
				if (c5x.o.b != null)
				{
					c66 c = new c66();
					c.a(this.g);
					c.a(this.e);
					c.b(this.i);
					c.a(this.j);
					c.e(this.h);
					c.b(this.f);
					c.a(this.k);
					c.c(this.l);
					c.ym(A_0, A_1, A_2);
					return;
				}
				if (c5x.p.b != null)
				{
					bi5 bi = new bi5();
					bi.a(this.g);
					bi.a(this.e);
					bi.a(this.d);
					bi.b(this.i);
					bi.a(this.j);
					bi.a(this.h);
					bi.e(this.f);
					bi.b(this.k);
					bi.c(this.l);
					bi.ym(A_0, A_1, A_2);
				}
			}
		}
	}

	// Token: 0x06005763 RID: 22371 RVA: 0x002627E4 File Offset: 0x002609E4
	[CompilerGenerated]
	private bool a(coh A_0)
	{
		return A_0.Definition.a5() == this.b;
	}

	// Token: 0x04002353 RID: 9043
	private new bool a;

	// Token: 0x04002354 RID: 9044
	private string b;

	// Token: 0x04002355 RID: 9045
	private bool c;

	// Token: 0x04002356 RID: 9046
	private int? d;

	// Token: 0x04002357 RID: 9047
	private Color? e;

	// Token: 0x04002358 RID: 9048
	private bool f;

	// Token: 0x04002359 RID: 9049
	private float? g;

	// Token: 0x0400235A RID: 9050
	private bool h;

	// Token: 0x0400235B RID: 9051
	private int i;

	// Token: 0x0400235C RID: 9052
	private int j;

	// Token: 0x0400235D RID: 9053
	private bool k;

	// Token: 0x0400235E RID: 9054
	private bool l;
}
