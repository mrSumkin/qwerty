using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200109B RID: 4251
[eiz("TCSJ")]
[Serializable]
public sealed class cha : cze
{
	// Token: 0x06005921 RID: 22817 RVA: 0x0026926C File Offset: 0x0026746C
	private cha(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("TCSJ:E", ref this.a, A_0);
		if (ell.a() >= 488)
		{
			this.b = (A_0.GetValue("TCSJ:S", typeof(int?)) as int?);
		}
	}

	// Token: 0x06005922 RID: 22818 RVA: 0x002692D4 File Offset: 0x002674D4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("TCSJ:E", this.a, info);
		info.AddValue("TCSJ:S", this.b);
	}

	// Token: 0x06005923 RID: 22819 RVA: 0x00269308 File Offset: 0x00267508
	public List<Guid> a()
	{
		return this.a;
	}

	// Token: 0x06005924 RID: 22820 RVA: 0x00269310 File Offset: 0x00267510
	public void a(List<Guid> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005925 RID: 22821 RVA: 0x0026931C File Offset: 0x0026751C
	public int? b()
	{
		return this.b;
	}

	// Token: 0x06005926 RID: 22822 RVA: 0x00269324 File Offset: 0x00267524
	public void a(int? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005927 RID: 22823 RVA: 0x00269330 File Offset: 0x00267530
	public cha()
	{
	}

	// Token: 0x06005928 RID: 22824 RVA: 0x00269344 File Offset: 0x00267544
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		bool a_ = true;
		if (aud != null)
		{
			foreach (Guid a_2 in this.a)
			{
				c5x c5x = new ar7(a_2, aud).ao() as c5x;
				if (c5x != null)
				{
					c2x aspect = c5x.GetAspect<c2x>();
					if (aspect != null && aspect.a(this.b, a_))
					{
						a_ = false;
					}
				}
			}
		}
	}

	// Token: 0x040023DC RID: 9180
	private new List<Guid> a = new List<Guid>();

	// Token: 0x040023DD RID: 9181
	private int? b;
}
