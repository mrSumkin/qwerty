using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012AF RID: 4783
[eiz("NREA")]
[Serializable]
public abstract class crb : Aspect<c5x>, ISerializable, bp1
{
	// Token: 0x060068EE RID: 26862 RVA: 0x002C524C File Offset: 0x002C344C
	protected crb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("NREA:V");
	}

	// Token: 0x060068EF RID: 26863 RVA: 0x002C5268 File Offset: 0x002C3468
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("NREA:V", this.b);
	}

	// Token: 0x060068F0 RID: 26864 RVA: 0x002C5284 File Offset: 0x002C3484
	public int e()
	{
		return this.b;
	}

	// Token: 0x060068F1 RID: 26865 RVA: 0x002C528C File Offset: 0x002C348C
	public void b(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060068F2 RID: 26866 RVA: 0x002C5298 File Offset: 0x002C3498
	public crb(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060068F3 RID: 26867 RVA: 0x002C52A4 File Offset: 0x002C34A4
	public void a(ak1 A_0, double A_1)
	{
		if (A_1 >= (double)this.b)
		{
			this.aiq(A_0, A_1);
		}
	}

	// Token: 0x060068F4 RID: 26868 RVA: 0x002C52BC File Offset: 0x002C34BC
	public void mx()
	{
		if (base.a8() != null)
		{
			e3l e3l = base.a8().GetAspect<e3l>();
			if (e3l == null)
			{
				e3l = new e3l(base.a8());
				base.a8().SetAspect<e3l>(e3l);
			}
			if (!e3l.a.Contains(crb.a))
			{
				e3l.a.Add(crb.a);
				e3l.a();
			}
		}
	}

	// Token: 0x060068F5 RID: 26869 RVA: 0x002C532C File Offset: 0x002C352C
	public void my()
	{
	}

	// Token: 0x060068F6 RID: 26870
	protected abstract void aiq(ak1 A_0, double A_1);

	// Token: 0x04002B57 RID: 11095
	public static readonly string a = "NoiseReceiver";

	// Token: 0x04002B58 RID: 11096
	private int b;
}
