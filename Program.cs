var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    return Results.Content("""
    <!DOCTYPE html>
    <html>
    <head>
        <title>Cloud Comparison App</title>
        <style>
            body {
                font-family: Arial;
                background: #0f172a;
                color: white;
                text-align: center;
                padding-top: 80px;
                margin: 0;
            }

            .card {
                background: #1e293b;
                width: 520px;
                margin: auto;
                padding: 35px;
                border-radius: 15px;
                box-shadow: 0 0 25px rgba(0,0,0,0.5);
            }

            h1 {
                color: #38bdf8;
                margin-bottom: 10px;
            }

            .subtitle {
                color: #94a3b8;
                font-size: 14px;
                margin-bottom: 20px;
            }

            .info {
                margin-top: 20px;
                font-size: 16px;
                line-height: 1.6;
                color: #e2e8f0;
            }

            .badge {
                background: #22c55e;
                padding: 10px 18px;
                border-radius: 30px;
                display: inline-block;
                margin-top: 25px;
                font-weight: bold;
            }

            .footer {
                margin-top: 20px;
                font-size: 12px;
                color: #64748b;
            }
        </style>
    </head>

    <body>
        <div class="card">
            <h1>AWS EC2 .NET Web Application</h1>

            <div class="subtitle">
                Cloud Infrastructure & Deployment Demonstration Project
            </div>

            <div class="info">
                <p>ASP.NET Core application deployed on an AWS EC2 instance</p>
                <p>Infrastructure provisioned using Terraform (Infrastructure as Code)</p>
                <p>Demonstrates automated cloud deployment and scalable architecture design</p>
                <p>Configured with secure networking and cloud-native best practices</p>
                <p>Designed for performance, cost, and reliability comparison between cloud platforms</p>
                <p>Supports CI/CD pipeline integration for automated deployment workflows</p>
            </div>

            <div class="badge">
                EC2 • Terraform • .NET 8
            </div>

            <div class="footer">
                Built for academic cloud comparison and DevOps learning
            </div>
        </div>
    </body>
    </html>
    """, "text/html");
});

app.Run();