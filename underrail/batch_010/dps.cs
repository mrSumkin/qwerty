using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02000087 RID: 135
public class dps : IFormatter
{
	// Token: 0x06000311 RID: 785 RVA: 0x0000DEB0 File Offset: 0x0000C0B0
	public dps()
	{
		this.a = new ev3();
		this.b = default(StreamingContext);
		this.c = new SurrogateSelector();
		this.d = new FormatterConverter();
		this.a(true);
	}

	// Token: 0x06000312 RID: 786 RVA: 0x0000DEEC File Offset: 0x0000C0EC
	public IFormatterConverter a()
	{
		return this.d;
	}

	// Token: 0x06000313 RID: 787 RVA: 0x0000DEF4 File Offset: 0x0000C0F4
	public void a(IFormatterConverter A_0)
	{
		if (A_0 == null)
		{
			throw new ArgumentNullException("value");
		}
		this.d = A_0;
	}

	// Token: 0x06000314 RID: 788 RVA: 0x0000DF10 File Offset: 0x0000C110
	[CompilerGenerated]
	public bool b()
	{
		return this.e;
	}

	// Token: 0x06000315 RID: 789 RVA: 0x0000DF18 File Offset: 0x0000C118
	[CompilerGenerated]
	private void a(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06000316 RID: 790 RVA: 0x0000DF24 File Offset: 0x0000C124
	public SerializationBinder get_Binder()
	{
		return this.a;
	}

	// Token: 0x06000317 RID: 791 RVA: 0x0000DF2C File Offset: 0x0000C12C
	public void set_Binder(SerializationBinder value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		this.a = value;
	}

	// Token: 0x06000318 RID: 792 RVA: 0x0000DF48 File Offset: 0x0000C148
	public StreamingContext get_Context()
	{
		return this.b;
	}

	// Token: 0x06000319 RID: 793 RVA: 0x0000DF50 File Offset: 0x0000C150
	public void set_Context(StreamingContext value)
	{
		this.b = value;
	}

	// Token: 0x0600031A RID: 794 RVA: 0x0000DF5C File Offset: 0x0000C15C
	public object Deserialize(Stream serializationStream)
	{
		return new ctc(serializationStream, this).t();
	}

	// Token: 0x0600031B RID: 795 RVA: 0x0000DF6C File Offset: 0x0000C16C
	public void Serialize(Stream serializationStream, object graph)
	{
		new be3(serializationStream, this).c(graph);
	}

	// Token: 0x0600031C RID: 796 RVA: 0x0000DF7C File Offset: 0x0000C17C
	public ISurrogateSelector get_SurrogateSelector()
	{
		return this.c;
	}

	// Token: 0x0600031D RID: 797 RVA: 0x0000DF84 File Offset: 0x0000C184
	public void set_SurrogateSelector(ISurrogateSelector value)
	{
		if (this.c == null)
		{
			throw new ArgumentNullException("surrogateSelector");
		}
		this.c = value;
	}

	// Token: 0x040003E6 RID: 998
	private SerializationBinder a;

	// Token: 0x040003E7 RID: 999
	private StreamingContext b;

	// Token: 0x040003E8 RID: 1000
	private ISurrogateSelector c;

	// Token: 0x040003E9 RID: 1001
	private IFormatterConverter d;

	// Token: 0x040003EA RID: 1002
	[CompilerGenerated]
	private bool e;
}
